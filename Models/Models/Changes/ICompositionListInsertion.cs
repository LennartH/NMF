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
    /// The public interface for CompositionListInsertion
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CompositionListInsertion))]
    [XmlDefaultImplementationTypeAttribute(typeof(CompositionListInsertion))]
    public interface ICompositionListInsertion : NMF.Models.IModelElement, ICompositionChange
    {
        
        /// <summary>
        /// The index property
        /// </summary>
        [XmlElementNameAttribute("index")]
        [XmlAttributeAttribute(true)]
        int Index
        {
            get;
            set;
        }
        
        /// <summary>
        /// The addedElement property
        /// </summary>
        [XmlElementNameAttribute("addedElement")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        NMF.Models.IModelElement AddedElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Index property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IndexChanging;
        
        /// <summary>
        /// Gets fired when the Index property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IndexChanged;
        
        /// <summary>
        /// Gets fired before the AddedElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddedElementChanging;
        
        /// <summary>
        /// Gets fired when the AddedElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddedElementChanged;
    }
}

