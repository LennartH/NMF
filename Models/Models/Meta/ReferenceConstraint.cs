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
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the ReferenceConstraint class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//ReferenceConstraint/")]
    public class ReferenceConstraint : ModelElement, IReferenceConstraint, IModelElement
    {
        
        /// <summary>
        /// The backing field for the References property
        /// </summary>
        private ObservableAssociationList<IModelElement> _references;
        
        /// <summary>
        /// The backing field for the Constrains property
        /// </summary>
        private IReference _constrains;
        
        private static IClass _classInstance;
        
        public ReferenceConstraint()
        {
            this._references = new ObservableAssociationList<IModelElement>();
            this._references.CollectionChanging += this.ReferencesCollectionChanging;
            this._references.CollectionChanged += this.ReferencesCollectionChanged;
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReferenceConstraints")]
        public virtual IClass DeclaringType
        {
            get
            {
                return ModelHelper.CastAs<IClass>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The References property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IListExpression<IModelElement> References
        {
            get
            {
                return this._references;
            }
        }
        
        /// <summary>
        /// The Constrains property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IReference Constrains
        {
            get
            {
                return this._constrains;
            }
            set
            {
                if ((this._constrains != value))
                {
                    IReference old = this._constrains;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConstrainsChanging(e);
                    this.OnPropertyChanging("Constrains", e);
                    this._constrains = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetConstrains;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetConstrains;
                    }
                    this.OnConstrainsChanged(e);
                    this.OnPropertyChanged("Constrains", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ReferenceConstraintReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//ReferenceConstraint/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired before the Constrains property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstrainsChanging;
        
        /// <summary>
        /// Gets fired when the Constrains property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstrainsChanged;
        
        /// <summary>
        /// Raises the DeclaringTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IClass oldDeclaringType = ModelHelper.CastAs<IClass>(oldParent);
            IClass newDeclaringType = ModelHelper.CastAs<IClass>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanging(e);
            this.OnPropertyChanging("DeclaringType");
        }
        
        /// <summary>
        /// Raises the DeclaringTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IClass oldDeclaringType = ModelHelper.CastAs<IClass>(oldParent);
            IClass newDeclaringType = ModelHelper.CastAs<IClass>(newParent);
            if ((oldDeclaringType != null))
            {
                oldDeclaringType.ReferenceConstraints.Remove(this);
            }
            if ((newDeclaringType != null))
            {
                newDeclaringType.ReferenceConstraints.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanged(e);
            this.OnPropertyChanged("DeclaringType", e);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the References property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReferencesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("References", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the References property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReferencesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("References", e);
        }
        
        /// <summary>
        /// Raises the ConstrainsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstrainsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstrainsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConstrainsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstrainsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstrainsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Constrains property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConstrains(object sender, System.EventArgs eventArgs)
        {
            this.Constrains = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "REFERENCES"))
            {
                return this._references;
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
            if ((feature == "DECLARINGTYPE"))
            {
                this.DeclaringType = ((IClass)(value));
                return;
            }
            if ((feature == "CONSTRAINS"))
            {
                this.Constrains = ((IReference)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
            }
            if ((attribute == "CONSTRAINS"))
            {
                return new ConstrainsProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
            }
            if ((reference == "CONSTRAINS"))
            {
                return new ConstrainsProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//ReferenceConstraint/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ReferenceConstraint class
        /// </summary>
        public class ReferenceConstraintReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ReferenceConstraint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ReferenceConstraintReferencedElementsCollection(ReferenceConstraint parent)
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
                    if ((this._parent.DeclaringType != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.References.Count);
                    if ((this._parent.Constrains != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DeclaringTypeChanged += this.PropagateValueChanges;
                this._parent.References.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ConstrainsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DeclaringTypeChanged -= this.PropagateValueChanges;
                this._parent.References.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ConstrainsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.DeclaringType == null))
                {
                    IClass declaringTypeCasted = item.As<IClass>();
                    if ((declaringTypeCasted != null))
                    {
                        this._parent.DeclaringType = declaringTypeCasted;
                        return;
                    }
                }
                this._parent.References.Add(item);
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DeclaringType = null;
                this._parent.References.Clear();
                this._parent.Constrains = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.DeclaringType))
                {
                    return true;
                }
                if (this._parent.References.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Constrains))
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
                if ((this._parent.DeclaringType != null))
                {
                    array[arrayIndex] = this._parent.DeclaringType;
                    arrayIndex = (arrayIndex + 1);
                }
                this._parent.References.CopyTo(array, arrayIndex);
                arrayIndex = (arrayIndex + this._parent.References.Count);
                if ((this._parent.Constrains != null))
                {
                    array[arrayIndex] = this._parent.Constrains;
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
                if ((this._parent.DeclaringType == item))
                {
                    this._parent.DeclaringType = null;
                    return true;
                }
                if (this._parent.References.Remove(item))
                {
                    return true;
                }
                if ((this._parent.Constrains == item))
                {
                    this._parent.Constrains = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DeclaringType).Concat(this._parent.References).Concat(this._parent.Constrains).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeclaringType property
        /// </summary>
        private sealed class DeclaringTypeProxy : ModelPropertyChange<IReferenceConstraint, IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeclaringTypeProxy(IReferenceConstraint modelElement) : 
                    base(modelElement, "DeclaringType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IClass Value
            {
                get
                {
                    return this.ModelElement.DeclaringType;
                }
                set
                {
                    this.ModelElement.DeclaringType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Constrains property
        /// </summary>
        private sealed class ConstrainsProxy : ModelPropertyChange<IReferenceConstraint, IReference>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConstrainsProxy(IReferenceConstraint modelElement) : 
                    base(modelElement, "Constrains")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IReference Value
            {
                get
                {
                    return this.ModelElement.Constrains;
                }
                set
                {
                    this.ModelElement.Constrains = value;
                }
            }
        }
    }
}

