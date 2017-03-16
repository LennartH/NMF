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
    /// The default implementation of the Extension class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Extension/")]
    [DebuggerDisplayAttribute("Extension {Name}")]
    public class Extension : ReferenceType, IExtension, IModelElement
    {
        
        /// <summary>
        /// The backing field for the AdornedClass property
        /// </summary>
        private IClass _adornedClass;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The AdornedClass property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IClass AdornedClass
        {
            get
            {
                return this._adornedClass;
            }
            set
            {
                if ((this._adornedClass != value))
                {
                    IClass old = this._adornedClass;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAdornedClassChanging(e);
                    this.OnPropertyChanging("AdornedClass", e);
                    this._adornedClass = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAdornedClass;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAdornedClass;
                    }
                    this.OnAdornedClassChanged(e);
                    this.OnPropertyChanged("AdornedClass", e);
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
                return base.ReferencedElements.Concat(new ExtensionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Extension/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AdornedClass property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AdornedClassChanging;
        
        /// <summary>
        /// Gets fired when the AdornedClass property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AdornedClassChanged;
        
        /// <summary>
        /// Raises the AdornedClassChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAdornedClassChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AdornedClassChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AdornedClassChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAdornedClassChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AdornedClassChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AdornedClass property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAdornedClass(object sender, System.EventArgs eventArgs)
        {
            this.AdornedClass = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ADORNEDCLASS"))
            {
                this.AdornedClass = ((IClass)(value));
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
            if ((attribute == "ADORNEDCLASS"))
            {
                return new AdornedClassProxy(this);
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
            if ((reference == "ADORNEDCLASS"))
            {
                return new AdornedClassProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Extension/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Extension class
        /// </summary>
        public class ExtensionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Extension _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ExtensionReferencedElementsCollection(Extension parent)
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
                    if ((this._parent.AdornedClass != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AdornedClassChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AdornedClassChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.AdornedClass == null))
                {
                    IClass adornedClassCasted = item.As<IClass>();
                    if ((adornedClassCasted != null))
                    {
                        this._parent.AdornedClass = adornedClassCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AdornedClass = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.AdornedClass))
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
                if ((this._parent.AdornedClass != null))
                {
                    array[arrayIndex] = this._parent.AdornedClass;
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
                if ((this._parent.AdornedClass == item))
                {
                    this._parent.AdornedClass = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AdornedClass).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AdornedClass property
        /// </summary>
        private sealed class AdornedClassProxy : ModelPropertyChange<IExtension, IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AdornedClassProxy(IExtension modelElement) : 
                    base(modelElement, "AdornedClass")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IClass Value
            {
                get
                {
                    return this.ModelElement.AdornedClass;
                }
                set
                {
                    this.ModelElement.AdornedClass = value;
                }
            }
        }
    }
}

