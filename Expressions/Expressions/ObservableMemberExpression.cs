﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace NMF.Expressions
{
    internal class ObservableMemberExpression<TTarget, TMember> : NotifyExpression<TMember>
    {
        public ObservableMemberExpression(MemberExpression expression, ObservableExpressionBinder binder, string name, Func<TTarget, TMember> getter)
            : this(binder.VisitObservable<TTarget>(expression.Expression, true), name, getter) { }

        public ObservableMemberExpression(INotifyExpression<TTarget> target, string memberName, Func<TTarget, TMember> memberGet)
        {
            if (memberGet == null) throw new ArgumentNullException("memberGet");
            if (memberName == null) throw new ArgumentNullException("memberName");

            Target = target;
            MemberGet = memberGet;
            MemberName = memberName;
        }
        
        public override ExpressionType NodeType { get { return ExpressionType.MemberAccess; } }

        public override bool CanBeConstant
        {
            get
            {
                if (Target == null) return true;
                if (!Target.IsConstant) return false;
                return Target.Value == null ||
                    !(Target.Value is INotifyPropertyChanged);
            }
        }

        public INotifyExpression<TTarget> Target { get; private set; }

        public Func<TTarget, TMember> MemberGet { get; private set; }

        public string MemberName { get; private set; }

        public override IEnumerable<INotifiable> Dependencies
        {
            get
            {
                if (Target != null)
                    yield return Target;
                    
            }
        }

        protected override TMember GetValue()
        {
            if (Target != null)
            {
                return MemberGet(Target.Value);
            }
            else
            {
                return MemberGet(default(TTarget));
            }
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", Target.ToString(), MemberName);
        }

        public override bool IsParameterFree
        {
            get { return Target == null || Target.IsParameterFree; }
        }

        public override INotifyExpression<TMember> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableMemberExpression<TTarget, TMember>(Target.ApplyParameters(parameters), MemberName, MemberGet);
        }

        public override INotificationResult Notify(IList<INotificationResult> sources)
        {
            if (sources.Count > 0)
            {
                var oldValue = ((ValueChangedNotificationResult<TTarget>)sources[0]).OldValue;
                DetachPropertyChangeListener(oldValue);
                AttachPropertyChangeListener(Target.Value);
            }
            return base.Notify(sources);
        }

        protected override void OnAttach()
        {
            if (Target != null)
                AttachPropertyChangeListener(Target.Value);
        }

        protected override void OnDetach()
        {
            if (Target != null)
                DetachPropertyChangeListener(Target.Value);
        }

        private void AttachPropertyChangeListener(object target)
        {
            var newTarget = target as INotifyPropertyChanged;
            if (newTarget != null)
                ExecutionContext.Instance.AddChangeListener(this, newTarget, MemberName);
        }

        private void DetachPropertyChangeListener(object target)
        {
            var oldTarget = target as INotifyPropertyChanged;
            if (oldTarget != null)
                ExecutionContext.Instance.RemoveChangeListener(this, oldTarget, MemberName);
        }
    }

    internal class ObservableReversableMemberExpression<TTarget, TMember> : ObservableReversableExpression<TMember>
    {
        public ObservableReversableMemberExpression(MemberExpression expression, ObservableExpressionBinder binder, string name, FieldInfo field)
            : this(binder.VisitObservable<TTarget>(expression.Expression, true), name, ReflectionHelper.CreateDynamicFieldGetter<TTarget, TMember>(field), ReflectionHelper.CreateDynamicFieldSetter<TTarget, TMember>(field)) { }

        public ObservableReversableMemberExpression(MemberExpression expression, ObservableExpressionBinder binder, string name, Func<TTarget, TMember> getter, Action<TTarget, TMember> setter)
            : this(binder.VisitObservable<TTarget>(expression.Expression, true), name, getter, setter) { }

        public ObservableReversableMemberExpression(INotifyExpression<TTarget> target, string memberName, Func<TTarget, TMember> memberGet, Action<TTarget, TMember> memberSet)
        {
            if (memberGet == null) throw new ArgumentNullException("memberGet");
            if (memberSet == null) throw new ArgumentNullException("memberSet");
            if (memberName == null) throw new ArgumentNullException("memberName");

            Target = target;
            MemberGet = memberGet;
            MemberSet = memberSet;
            MemberName = memberName;
        }
        
        public override ExpressionType NodeType { get { return ExpressionType.MemberAccess; } }

        public override bool CanBeConstant
        {
            get
            {
                if (Target == null) return true;
                if (!Target.CanBeConstant) return false;
                return Target.Value == null ||
                    !(Target.Value is INotifyPropertyChanged);
            }
        }

        public INotifyExpression<TTarget> Target { get; private set; }

        public Func<TTarget, TMember> MemberGet { get; private set; }

        public Action<TTarget, TMember> MemberSet { get; set; }

        public string MemberName { get; private set; }

        public override bool IsParameterFree
        {
            get { return Target == null || Target.IsParameterFree; }
        }

        public override IEnumerable<INotifiable> Dependencies
        {
            get
            {
                if (Target != null)
                    yield return Target;
            }
        }

        protected override TMember GetValue()
        {
            if (Target != null)
            {
                if (Target.Value == null)
                    return default(TMember);
                return MemberGet(Target.Value);
            }
            else
            {
                return MemberGet(default(TTarget));
            }
        }

        public override void SetValue(TMember value)
        {
            if (Target != null)
            {
                if (Target.Value != null)
                {
                    MemberSet(Target.Value, value);
                }
                else
                {
                    if (value != null) throw new NullReferenceException();
                }
            }
            else
            {
                MemberSet(default(TTarget), value);
            }
        }

        public override INotifyExpression<TMember> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableReversableMemberExpression<TTarget, TMember>(Target.ApplyParameters(parameters), MemberName, MemberGet, MemberSet);
        }

        public override INotificationResult Notify(IList<INotificationResult> sources)
        {
            if (sources.Count > 0)
            {
                var oldValue = ((IValueChangedNotificationResult)sources[0]).OldValue;
                DetachPropertyChangeListener(oldValue);
                AttachPropertyChangeListener(Target.Value);
            }
            return base.Notify(sources);
        }

        protected override void OnAttach()
        {
            if (Target != null)
                AttachPropertyChangeListener(Target.Value);
        }

        protected override void OnDetach()
        {
            if (Target != null)
                DetachPropertyChangeListener(Target.Value);
        }

        private void AttachPropertyChangeListener(object target)
        {
            var newTarget = target as INotifyPropertyChanged;
            if (newTarget != null)
                ExecutionContext.Instance.AddChangeListener(this, newTarget, MemberName);
        }

        private void DetachPropertyChangeListener(object target)
        {
            var oldTarget = target as INotifyPropertyChanged;
            if (oldTarget != null)
                ExecutionContext.Instance.RemoveChangeListener(this, oldTarget, MemberName);
        }
    }
}
