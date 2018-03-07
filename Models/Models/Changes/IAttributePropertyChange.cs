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
    /// The public interface for AttributePropertyChange
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AttributePropertyChange))]
    [XmlDefaultImplementationTypeAttribute(typeof(AttributePropertyChange))]
    public interface IAttributePropertyChange : NMF.Models.IModelElement, IAttributeChange
    {
        
        /// <summary>
        /// The newValue property
        /// </summary>
        [XmlElementNameAttribute("newValue")]
        [XmlAttributeAttribute(true)]
        string NewValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// The oldValue property
        /// </summary>
        [XmlElementNameAttribute("oldValue")]
        [XmlAttributeAttribute(true)]
        string OldValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the NewValue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NewValueChanging;
        
        /// <summary>
        /// Gets fired when the NewValue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NewValueChanged;
        
        /// <summary>
        /// Gets fired before the OldValue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OldValueChanging;
        
        /// <summary>
        /// Gets fired when the OldValue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OldValueChanged;
    }
}

