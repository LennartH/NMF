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
    /// The default implementation of the AssociationListDeletion class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//AssociationListDeletion")]
    public partial class AssociationListDeletion : AssociationChange, IAssociationListDeletion, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the Index property
        /// </summary>
        private int _index;
        
        private static Lazy<ITypedElement> _indexAttribute = new Lazy<ITypedElement>(RetrieveIndexAttribute);
        
        private static Lazy<ITypedElement> _deletedElementReference = new Lazy<ITypedElement>(RetrieveDeletedElementReference);
        
        /// <summary>
        /// The backing field for the DeletedElement property
        /// </summary>
        private NMF.Models.IModelElement _deletedElement;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The index property
        /// </summary>
        [XmlElementNameAttribute("index")]
        [XmlAttributeAttribute(true)]
        public int Index
        {
            get
            {
                return this._index;
            }
            set
            {
                if ((this._index != value))
                {
                    int old = this._index;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIndexChanging(e);
                    this.OnPropertyChanging("Index", e, _indexAttribute);
                    this._index = value;
                    this.OnIndexChanged(e);
                    this.OnPropertyChanged("Index", e, _indexAttribute);
                }
            }
        }
        
        /// <summary>
        /// The deletedElement property
        /// </summary>
        [XmlElementNameAttribute("deletedElement")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.IModelElement DeletedElement
        {
            get
            {
                return this._deletedElement;
            }
            set
            {
                if ((this._deletedElement != value))
                {
                    NMF.Models.IModelElement old = this._deletedElement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDeletedElementChanging(e);
                    this.OnPropertyChanging("DeletedElement", e, _deletedElementReference);
                    this._deletedElement = value;
                    this.OnDeletedElementChanged(e);
                    this.OnPropertyChanged("DeletedElement", e, _deletedElementReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AssociationListDeletionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AssociationListDeletion")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Index property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IndexChanging;
        
        /// <summary>
        /// Gets fired when the Index property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IndexChanged;
        
        /// <summary>
        /// Gets fired before the DeletedElement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeletedElementChanging;
        
        /// <summary>
        /// Gets fired when the DeletedElement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeletedElementChanged;
        
        private static ITypedElement RetrieveIndexAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(AssociationListDeletion.ClassInstance)).Resolve("index")));
        }
        
        /// <summary>
        /// Raises the IndexChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIndexChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IndexChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IndexChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIndexChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IndexChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDeletedElementReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(AssociationListDeletion.ClassInstance)).Resolve("deletedElement")));
        }
        
        /// <summary>
        /// Raises the DeletedElementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeletedElementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeletedElementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DeletedElementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeletedElementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeletedElementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "DELETEDELEMENT"))
            {
                return this.DeletedElement;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "INDEX"))
            {
                return this.Index;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "DELETEDELEMENT"))
            {
                this.DeletedElement = ((NMF.Models.IModelElement)(value));
                return;
            }
            if ((feature == "INDEX"))
            {
                this.Index = ((int)(value));
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
            if ((attribute == "INDEX"))
            {
                return Observable.Box(new IndexProxy(this));
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
            if ((reference == "DELETEDELEMENT"))
            {
                return new DeletedElementProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AssociationListDeletion")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssociationListDeletion class
        /// </summary>
        public class AssociationListDeletionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private AssociationListDeletion _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssociationListDeletionReferencedElementsCollection(AssociationListDeletion parent)
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
                    if ((this._parent.DeletedElement != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DeletedElementChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DeletedElementChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.DeletedElement == null))
                {
                    this._parent.DeletedElement = item;
                    return;
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DeletedElement = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.DeletedElement))
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
                if ((this._parent.DeletedElement != null))
                {
                    array[arrayIndex] = this._parent.DeletedElement;
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
                if ((this._parent.DeletedElement == item))
                {
                    this._parent.DeletedElement = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.DeletedElement).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the index property
        /// </summary>
        private sealed class IndexProxy : ModelPropertyChange<IAssociationListDeletion, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IndexProxy(IAssociationListDeletion modelElement) : 
                    base(modelElement, "index")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.Index;
                }
                set
                {
                    this.ModelElement.Index = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the deletedElement property
        /// </summary>
        private sealed class DeletedElementProxy : ModelPropertyChange<IAssociationListDeletion, NMF.Models.IModelElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeletedElementProxy(IAssociationListDeletion modelElement) : 
                    base(modelElement, "deletedElement")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.IModelElement Value
            {
                get
                {
                    return this.ModelElement.DeletedElement;
                }
                set
                {
                    this.ModelElement.DeletedElement = value;
                }
            }
        }
    }
}

