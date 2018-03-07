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
    /// The MappedType extension
    /// </summary>
    public class MappedType : ModelElementExtension<IType, MappedType>
    {
        
        /// <summary>
        /// The backing field for the SystemType property
        /// </summary>
        private System.Type _systemType;
        
        private static Lazy<ITypedElement> _systemTypeAttribute = new Lazy<ITypedElement>(RetrieveSystemTypeAttribute);
        
        private static IExtension _extensionType;
        
        /// <summary>
        /// The SystemType property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public System.Type SystemType
        {
            get
            {
                return this._systemType;
            }
            set
            {
                if ((this._systemType != value))
                {
                    System.Type old = this._systemType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSystemTypeChanging(e);
                    this.OnPropertyChanging("SystemType", e, _systemTypeAttribute);
                    this._systemType = value;
                    this.OnSystemTypeChanged(e);
                    this.OnPropertyChanged("SystemType", e, _systemTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets fired before the SystemType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SystemTypeChanging;
        
        /// <summary>
        /// Gets fired when the SystemType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SystemTypeChanged;
        
        private static ITypedElement RetrieveSystemTypeAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(MappedType.ClassInstance)).Resolve("SystemType")));
        }
        
        /// <summary>
        /// Raises the SystemTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystemTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SystemTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SystemTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystemTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SystemTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the MappedType extension from the given model element
        /// </summary>
        /// <returns>The extension object or null, if the model element does not have this extension</returns>
        /// <param name="parent">The parent model element that may hold the extension</param>
        public static MappedType FromType(IType parent)
        {
            if ((parent == null))
            {
                return null;
            }
            MappedType extension = parent.GetExtension<MappedType>();
            if ((extension != null))
            {
                return extension;
            }
            extension = new MappedType { Parent = parent };
            parent.Extensions.Add(extension);
            return extension;
        }
        
        /// <summary>
        /// Gets the extension model element for the given model extension class
        /// </summary>
        public override IExtension GetExtension()
        {
            if ((_extensionType == null))
            {
                _extensionType = ((IExtension)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//MappedType")));
            }
            return _extensionType;
        }
    }
}

