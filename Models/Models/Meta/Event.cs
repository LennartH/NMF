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

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// Represents an event
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Event")]
    [DebuggerDisplayAttribute("Event {Name}")]
    public partial class Event : MetaElement, IEvent, NMF.Models.IModelElement
    {
        
        private static Lazy<ITypedElement> _typeReference = new Lazy<ITypedElement>(RetrieveTypeReference);
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private IDataType _type;
        
        private static Lazy<ITypedElement> _declaringTypeReference = new Lazy<ITypedElement>(RetrieveDeclaringTypeReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IDataType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    IDataType old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e, _typeReference);
                    this._type = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetType;
                    }
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e, _typeReference);
                }
            }
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Events")]
        public IReferenceType DeclaringType
        {
            get
            {
                return ModelHelper.CastAs<IReferenceType>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EventReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Event")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        private static ITypedElement RetrieveTypeReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Event.ClassInstance)).Resolve("Type")));
        }
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Type property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetType(object sender, System.EventArgs eventArgs)
        {
            this.Type = null;
        }
        
        private static ITypedElement RetrieveDeclaringTypeReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Event.ClassInstance)).Resolve("DeclaringType")));
        }
        
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
        protected override void OnParentChanging(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IReferenceType oldDeclaringType = ModelHelper.CastAs<IReferenceType>(oldParent);
            IReferenceType newDeclaringType = ModelHelper.CastAs<IReferenceType>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanging(e);
            this.OnPropertyChanging("DeclaringType", e, _declaringTypeReference);
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
        protected override void OnParentChanged(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IReferenceType oldDeclaringType = ModelHelper.CastAs<IReferenceType>(oldParent);
            IReferenceType newDeclaringType = ModelHelper.CastAs<IReferenceType>(newParent);
            if ((oldDeclaringType != null))
            {
                oldDeclaringType.Events.Remove(this);
            }
            if ((newDeclaringType != null))
            {
                newDeclaringType.Events.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanged(e);
            this.OnPropertyChanged("DeclaringType", e, _declaringTypeReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "TYPE"))
            {
                return this.Type;
            }
            if ((reference == "DECLARINGTYPE"))
            {
                return this.DeclaringType;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TYPE"))
            {
                this.Type = ((IDataType)(value));
                return;
            }
            if ((feature == "DECLARINGTYPE"))
            {
                this.DeclaringType = ((IReferenceType)(value));
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
            if ((reference == "TYPE"))
            {
                return new TypeProxy(this);
            }
            if ((reference == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Event")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Event class
        /// </summary>
        public class EventReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Event _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventReferencedElementsCollection(Event parent)
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
                    if ((this._parent.Type != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.DeclaringType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TypeChanged += this.PropagateValueChanges;
                this._parent.DeclaringTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TypeChanged -= this.PropagateValueChanges;
                this._parent.DeclaringTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Type == null))
                {
                    IDataType typeCasted = item.As<IDataType>();
                    if ((typeCasted != null))
                    {
                        this._parent.Type = typeCasted;
                        return;
                    }
                }
                if ((this._parent.DeclaringType == null))
                {
                    IReferenceType declaringTypeCasted = item.As<IReferenceType>();
                    if ((declaringTypeCasted != null))
                    {
                        this._parent.DeclaringType = declaringTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Type = null;
                this._parent.DeclaringType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Type))
                {
                    return true;
                }
                if ((item == this._parent.DeclaringType))
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
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Type != null))
                {
                    array[arrayIndex] = this._parent.Type;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.DeclaringType != null))
                {
                    array[arrayIndex] = this._parent.DeclaringType;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Type == item))
                {
                    this._parent.Type = null;
                    return true;
                }
                if ((this._parent.DeclaringType == item))
                {
                    this._parent.DeclaringType = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Type).Concat(this._parent.DeclaringType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IEvent, IDataType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IEvent modelElement) : 
                    base(modelElement, "Type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDataType Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeclaringType property
        /// </summary>
        private sealed class DeclaringTypeProxy : ModelPropertyChange<IEvent, IReferenceType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeclaringTypeProxy(IEvent modelElement) : 
                    base(modelElement, "DeclaringType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IReferenceType Value
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
    }
}

