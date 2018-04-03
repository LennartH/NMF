//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Tests.Architecture
{
    
    
    /// <summary>
    /// The default implementation of the Class class
    /// </summary>
    [XmlNamespaceAttribute("test:architecture")]
    [XmlNamespacePrefixAttribute("")]
    [ModelRepresentationClassAttribute("test:architecture#//Class")]
    [DebuggerDisplayAttribute("Class {Name}")]
    public partial class Class : NamedElement, NMF.Models.Tests.Architecture.IClass, IModelElement
    {
        
        private static System.Lazy<IOperation> _pullUpFeatureOperation = new System.Lazy<IOperation>(RetrievePullUpFeatureOperation);
        
        private static Lazy<ITypedElement> _encapsulatesReference = new Lazy<ITypedElement>(RetrieveEncapsulatesReference);
        
        /// <summary>
        /// The backing field for the Encapsulates property
        /// </summary>
        private ClassEncapsulatesCollection _encapsulates;
        
        private static Lazy<ITypedElement> _baseTypeReference = new Lazy<ITypedElement>(RetrieveBaseTypeReference);
        
        /// <summary>
        /// The backing field for the BaseType property
        /// </summary>
        private NMF.Models.Tests.Architecture.IClass _baseType;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public Class()
        {
            this._encapsulates = new ClassEncapsulatesCollection(this);
            this._encapsulates.CollectionChanging += this.EncapsulatesCollectionChanging;
            this._encapsulates.CollectionChanged += this.EncapsulatesCollectionChanged;
        }
        
        /// <summary>
        /// The encapsulates property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("encapsulates")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("isEncapsulatedBy")]
        [ConstantAttribute()]
        public IListExpression<IFeature> Encapsulates
        {
            get
            {
                return this._encapsulates;
            }
        }
        
        /// <summary>
        /// The baseType property
        /// </summary>
        [XmlElementNameAttribute("baseType")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.Tests.Architecture.IClass BaseType
        {
            get
            {
                return this._baseType;
            }
            set
            {
                if ((this._baseType != value))
                {
                    NMF.Models.Tests.Architecture.IClass old = this._baseType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBaseTypeChanging(e);
                    this.OnPropertyChanging("BaseType", e, _baseTypeReference);
                    this._baseType = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetBaseType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetBaseType;
                    }
                    this.OnBaseTypeChanged(e);
                    this.OnPropertyChanged("BaseType", e, _baseTypeReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ClassChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ClassReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("test:architecture#//Class")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the operation pullUpFeature gets called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> PullUpFeatureCalling;
        
        /// <summary>
        /// Gets fired after the operation pullUpFeature got called
        /// </summary>
        public event System.EventHandler<OperationCallEventArgs> PullUpFeatureCalled;
        
        /// <summary>
        /// Gets fired before the BaseType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BaseTypeChanging;
        
        /// <summary>
        /// Gets fired when the BaseType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BaseTypeChanged;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        public void PullUpFeature(string methodName)
        {
            System.Action<NMF.Models.Tests.Architecture.IClass, string> handler = OperationBroker.Instance.GetRegisteredDelegate<System.Action<NMF.Models.Tests.Architecture.IClass, string>>(_pullUpFeatureOperation);
            if ((handler != null))
            {
            }
            else
            {
                throw new System.InvalidOperationException("There is no implementation for method pullUpFeature registered. Use the method br" +
                        "oker to register a method implementation.");
            }
            OperationCallEventArgs e = new OperationCallEventArgs(this, _pullUpFeatureOperation.Value, methodName);
            this.OnPullUpFeatureCalling(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalling(this, _pullUpFeatureOperation.Value, e));
            handler.Invoke(this, methodName);
            this.OnPullUpFeatureCalled(e);
            this.OnBubbledChange(BubbledChangeEventArgs.OperationCalled(this, _pullUpFeatureOperation.Value, e));
        }
        
        private static IOperation RetrievePullUpFeatureOperation()
        {
            return ClassInstance.LookupOperation("pullUpFeature");
        }
        
        /// <summary>
        /// Raises the PullUpFeatureCalling event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPullUpFeatureCalling(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.PullUpFeatureCalling;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PullUpFeatureCalled event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPullUpFeatureCalled(OperationCallEventArgs eventArgs)
        {
            System.EventHandler<OperationCallEventArgs> handler = this.PullUpFeatureCalled;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveEncapsulatesReference()
        {
            return ((ITypedElement)(((ModelElement)(Class.ClassInstance)).Resolve("encapsulates")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Encapsulates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EncapsulatesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Encapsulates", e, _encapsulatesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Encapsulates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EncapsulatesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Encapsulates", e, _encapsulatesReference);
        }
        
        private static ITypedElement RetrieveBaseTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(Class.ClassInstance)).Resolve("baseType")));
        }
        
        /// <summary>
        /// Raises the BaseTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBaseTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BaseTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BaseTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBaseTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BaseTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the BaseType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetBaseType(object sender, System.EventArgs eventArgs)
        {
            this.BaseType = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int encapsulatesIndex = ModelHelper.IndexOfReference(this.Encapsulates, element);
            if ((encapsulatesIndex != -1))
            {
                return ModelHelper.CreatePath("encapsulates", encapsulatesIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "ENCAPSULATES"))
            {
                if ((index < this.Encapsulates.Count))
                {
                    return this.Encapsulates[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "BASETYPE"))
            {
                return this.BaseType;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ENCAPSULATES"))
            {
                return this._encapsulates;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "BASETYPE"))
            {
                this.BaseType = ((NMF.Models.Tests.Architecture.IClass)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "BASETYPE"))
            {
                return new BaseTypeProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._encapsulates))
            {
                return "encapsulates";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("test:architecture#//Class")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Class class
        /// </summary>
        public class ClassChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Class _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ClassChildrenCollection(Class parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Encapsulates.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IFeature encapsulatesCasted = item.As<IFeature>();
                if ((encapsulatesCasted != null))
                {
                    this._parent.Encapsulates.Add(encapsulatesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Encapsulates.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Encapsulates.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> encapsulatesEnumerator = this._parent.Encapsulates.GetEnumerator();
                try
                {
                    for (
                    ; encapsulatesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = encapsulatesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    encapsulatesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IFeature featureItem = item.As<IFeature>();
                if (((featureItem != null) 
                            && this._parent.Encapsulates.Remove(featureItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Encapsulates).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Class class
        /// </summary>
        public class ClassReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Class _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ClassReferencedElementsCollection(Class parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Encapsulates.Count);
                    if ((this._parent.BaseType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.BaseTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Encapsulates.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.BaseTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IFeature encapsulatesCasted = item.As<IFeature>();
                if ((encapsulatesCasted != null))
                {
                    this._parent.Encapsulates.Add(encapsulatesCasted);
                }
                if ((this._parent.BaseType == null))
                {
                    NMF.Models.Tests.Architecture.IClass baseTypeCasted = item.As<NMF.Models.Tests.Architecture.IClass>();
                    if ((baseTypeCasted != null))
                    {
                        this._parent.BaseType = baseTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Encapsulates.Clear();
                this._parent.BaseType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Encapsulates.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.BaseType))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> encapsulatesEnumerator = this._parent.Encapsulates.GetEnumerator();
                try
                {
                    for (
                    ; encapsulatesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = encapsulatesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    encapsulatesEnumerator.Dispose();
                }
                if ((this._parent.BaseType != null))
                {
                    array[arrayIndex] = this._parent.BaseType;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IFeature featureItem = item.As<IFeature>();
                if (((featureItem != null) 
                            && this._parent.Encapsulates.Remove(featureItem)))
                {
                    return true;
                }
                if ((this._parent.BaseType == item))
                {
                    this._parent.BaseType = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Encapsulates).Concat(this._parent.BaseType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the baseType property
        /// </summary>
        private sealed class BaseTypeProxy : ModelPropertyChange<NMF.Models.Tests.Architecture.IClass, NMF.Models.Tests.Architecture.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BaseTypeProxy(NMF.Models.Tests.Architecture.IClass modelElement) : 
                    base(modelElement, "baseType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Tests.Architecture.IClass Value
            {
                get
                {
                    return this.ModelElement.BaseType;
                }
                set
                {
                    this.ModelElement.BaseType = value;
                }
            }
        }
    }
}
