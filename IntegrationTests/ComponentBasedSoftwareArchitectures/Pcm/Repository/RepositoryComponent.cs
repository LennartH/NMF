//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the RepositoryComponent class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RepositoryComponent" +
        "")]
    [DebuggerDisplayAttribute("RepositoryComponent {Id}")]
    public abstract partial class RepositoryComponent : InterfaceProvidingRequiringEntity, IRepositoryComponent, IModelElement
    {
        
        private static Lazy<ITypedElement> _repository__RepositoryComponentReference = new Lazy<ITypedElement>(RetrieveRepository__RepositoryComponentReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The repository__RepositoryComponent property
        /// </summary>
        [XmlElementNameAttribute("repository__RepositoryComponent")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("components__Repository")]
        public IRepository Repository__RepositoryComponent
        {
            get
            {
                return ModelHelper.CastAs<IRepository>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RepositoryComponentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RepositoryComponent" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Repository__RepositoryComponent property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__RepositoryComponentChanging;
        
        /// <summary>
        /// Gets fired when the Repository__RepositoryComponent property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__RepositoryComponentChanged;
        
        private static ITypedElement RetrieveRepository__RepositoryComponentReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.RepositoryComponent.ClassInstance)).Resolve("repository__RepositoryComponent")));
        }
        
        /// <summary>
        /// Raises the Repository__RepositoryComponentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__RepositoryComponentChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__RepositoryComponentChanging;
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
            IRepository oldRepository__RepositoryComponent = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__RepositoryComponent = ModelHelper.CastAs<IRepository>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__RepositoryComponent, newRepository__RepositoryComponent);
            this.OnRepository__RepositoryComponentChanging(e);
            this.OnPropertyChanging("Repository__RepositoryComponent", e, _repository__RepositoryComponentReference);
        }
        
        /// <summary>
        /// Raises the Repository__RepositoryComponentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__RepositoryComponentChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__RepositoryComponentChanged;
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
            IRepository oldRepository__RepositoryComponent = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__RepositoryComponent = ModelHelper.CastAs<IRepository>(newParent);
            if ((oldRepository__RepositoryComponent != null))
            {
                oldRepository__RepositoryComponent.Components__Repository.Remove(this);
            }
            if ((newRepository__RepositoryComponent != null))
            {
                newRepository__RepositoryComponent.Components__Repository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__RepositoryComponent, newRepository__RepositoryComponent);
            this.OnRepository__RepositoryComponentChanged(e);
            this.OnPropertyChanged("Repository__RepositoryComponent", e, _repository__RepositoryComponentReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REPOSITORY__REPOSITORYCOMPONENT"))
            {
                this.Repository__RepositoryComponent = ((IRepository)(value));
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
            if ((attribute == "Repository__RepositoryComponent"))
            {
                return new Repository__RepositoryComponentProxy(this);
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
            if ((reference == "Repository__RepositoryComponent"))
            {
                return new Repository__RepositoryComponentProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RepositoryComponent" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RepositoryComponent class
        /// </summary>
        public class RepositoryComponentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RepositoryComponent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RepositoryComponentReferencedElementsCollection(RepositoryComponent parent)
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
                    if ((this._parent.Repository__RepositoryComponent != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Repository__RepositoryComponentChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Repository__RepositoryComponentChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Repository__RepositoryComponent == null))
                {
                    IRepository repository__RepositoryComponentCasted = item.As<IRepository>();
                    if ((repository__RepositoryComponentCasted != null))
                    {
                        this._parent.Repository__RepositoryComponent = repository__RepositoryComponentCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Repository__RepositoryComponent = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Repository__RepositoryComponent))
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
                if ((this._parent.Repository__RepositoryComponent != null))
                {
                    array[arrayIndex] = this._parent.Repository__RepositoryComponent;
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
                if ((this._parent.Repository__RepositoryComponent == item))
                {
                    this._parent.Repository__RepositoryComponent = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Repository__RepositoryComponent).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the repository__RepositoryComponent property
        /// </summary>
        private sealed class Repository__RepositoryComponentProxy : ModelPropertyChange<IRepositoryComponent, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Repository__RepositoryComponentProxy(IRepositoryComponent modelElement) : 
                    base(modelElement, "repository__RepositoryComponent")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepository Value
            {
                get
                {
                    return this.ModelElement.Repository__RepositoryComponent;
                }
                set
                {
                    this.ModelElement.Repository__RepositoryComponent = value;
                }
            }
        }
    }
}
