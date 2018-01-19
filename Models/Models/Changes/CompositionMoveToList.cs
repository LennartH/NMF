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

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The default implementation of the CompositionMoveToList class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//CompositionMoveToList")]
    public partial class CompositionMoveToList : ListInsertion, ICompositionMoveToList, NMF.Models.IModelElement
    {
        
        private static Lazy<ITypedElement> _movedElementReference = new Lazy<ITypedElement>(RetrieveMovedElementReference);
        
        /// <summary>
        /// The backing field for the MovedElement property
        /// </summary>
        private NMF.Models.IModelElement _movedElement;
        
        private static Lazy<ITypedElement> _originReference = new Lazy<ITypedElement>(RetrieveOriginReference);
        
        /// <summary>
        /// The backing field for the Origin property
        /// </summary>
        private IElementaryChange _origin;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The movedElement property
        /// </summary>
        [XmlElementNameAttribute("movedElement")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.IModelElement MovedElement
        {
            get
            {
                return this._movedElement;
            }
            set
            {
                if ((this._movedElement != value))
                {
                    NMF.Models.IModelElement old = this._movedElement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMovedElementChanging(e);
                    this.OnPropertyChanging("MovedElement", e, _movedElementReference);
                    this._movedElement = value;
                    this.OnMovedElementChanged(e);
                    this.OnPropertyChanged("MovedElement", e, _movedElementReference);
                }
            }
        }
        
        /// <summary>
        /// The origin property
        /// </summary>
        [XmlElementNameAttribute("origin")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IElementaryChange Origin
        {
            get
            {
                return this._origin;
            }
            set
            {
                if ((this._origin != value))
                {
                    IElementaryChange old = this._origin;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOriginChanging(e);
                    this.OnPropertyChanging("Origin", e, _originReference);
                    this._origin = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetOrigin;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetOrigin;
                    }
                    this.OnOriginChanged(e);
                    this.OnPropertyChanged("Origin", e, _originReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CompositionMoveToListChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CompositionMoveToListReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//CompositionMoveToList")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MovedElement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MovedElementChanging;
        
        /// <summary>
        /// Gets fired when the MovedElement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MovedElementChanged;
        
        /// <summary>
        /// Gets fired before the Origin property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OriginChanging;
        
        /// <summary>
        /// Gets fired when the Origin property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OriginChanged;
        
        private static ITypedElement RetrieveMovedElementReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(CompositionMoveToList.ClassInstance)).Resolve("movedElement")));
        }
        
        /// <summary>
        /// Raises the MovedElementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMovedElementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MovedElementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MovedElementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMovedElementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MovedElementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the MovedElement property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMovedElement(object sender, System.EventArgs eventArgs)
        {
            this.MovedElement = null;
        }
        
        private static ITypedElement RetrieveOriginReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(CompositionMoveToList.ClassInstance)).Resolve("origin")));
        }
        
        /// <summary>
        /// Raises the OriginChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOriginChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OriginChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OriginChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOriginChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OriginChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Origin property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOrigin(object sender, System.EventArgs eventArgs)
        {
            this.Origin = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(NMF.Models.IModelElement element)
        {
            if ((element == this.Origin))
            {
                return ModelHelper.CreatePath("Origin");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "MOVEDELEMENT"))
            {
                return this.MovedElement;
            }
            if ((reference == "ORIGIN"))
            {
                return this.Origin;
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
            if ((feature == "MOVEDELEMENT"))
            {
                this.MovedElement = ((NMF.Models.IModelElement)(value));
                return;
            }
            if ((feature == "ORIGIN"))
            {
                this.Origin = ((IElementaryChange)(value));
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
            if ((reference == "MOVEDELEMENT"))
            {
                return new MovedElementProxy(this);
            }
            if ((reference == "ORIGIN"))
            {
                return new OriginProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//CompositionMoveToList")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositionMoveToList class
        /// </summary>
        public class CompositionMoveToListChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private CompositionMoveToList _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositionMoveToListChildrenCollection(CompositionMoveToList parent)
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
                    if ((this._parent.Origin != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OriginChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OriginChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Origin == null))
                {
                    IElementaryChange originCasted = item.As<IElementaryChange>();
                    if ((originCasted != null))
                    {
                        this._parent.Origin = originCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Origin = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Origin))
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
                if ((this._parent.Origin != null))
                {
                    array[arrayIndex] = this._parent.Origin;
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
                if ((this._parent.Origin == item))
                {
                    this._parent.Origin = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Origin).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositionMoveToList class
        /// </summary>
        public class CompositionMoveToListReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private CompositionMoveToList _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositionMoveToListReferencedElementsCollection(CompositionMoveToList parent)
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
                    if ((this._parent.MovedElement != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Origin != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MovedElementChanged += this.PropagateValueChanges;
                this._parent.OriginChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MovedElementChanged -= this.PropagateValueChanges;
                this._parent.OriginChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.MovedElement == null))
                {
                    this._parent.MovedElement = item;
                    return;
                }
                if ((this._parent.Origin == null))
                {
                    IElementaryChange originCasted = item.As<IElementaryChange>();
                    if ((originCasted != null))
                    {
                        this._parent.Origin = originCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MovedElement = null;
                this._parent.Origin = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.MovedElement))
                {
                    return true;
                }
                if ((item == this._parent.Origin))
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
                if ((this._parent.MovedElement != null))
                {
                    array[arrayIndex] = this._parent.MovedElement;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Origin != null))
                {
                    array[arrayIndex] = this._parent.Origin;
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
                if ((this._parent.MovedElement == item))
                {
                    this._parent.MovedElement = null;
                    return true;
                }
                if ((this._parent.Origin == item))
                {
                    this._parent.Origin = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.MovedElement).Concat(this._parent.Origin).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the movedElement property
        /// </summary>
        private sealed class MovedElementProxy : ModelPropertyChange<ICompositionMoveToList, NMF.Models.IModelElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MovedElementProxy(ICompositionMoveToList modelElement) : 
                    base(modelElement, "movedElement")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.IModelElement Value
            {
                get
                {
                    return this.ModelElement.MovedElement;
                }
                set
                {
                    this.ModelElement.MovedElement = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the origin property
        /// </summary>
        private sealed class OriginProxy : ModelPropertyChange<ICompositionMoveToList, IElementaryChange>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OriginProxy(ICompositionMoveToList modelElement) : 
                    base(modelElement, "origin")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IElementaryChange Value
            {
                get
                {
                    return this.ModelElement.Origin;
                }
                set
                {
                    this.ModelElement.Origin = value;
                }
            }
        }
    }
}

