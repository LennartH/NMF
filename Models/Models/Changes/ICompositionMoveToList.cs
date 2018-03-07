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
    /// The public interface for CompositionMoveToList
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CompositionMoveToList))]
    [XmlDefaultImplementationTypeAttribute(typeof(CompositionMoveToList))]
    public interface ICompositionMoveToList : NMF.Models.IModelElement, ICompositionChange
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
        /// The movedElement property
        /// </summary>
        [XmlElementNameAttribute("movedElement")]
        [XmlAttributeAttribute(true)]
        NMF.Models.IModelElement MovedElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The origin property
        /// </summary>
        [XmlElementNameAttribute("origin")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IElementaryChange Origin
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
        /// Gets fired before the MovedElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MovedElementChanging;
        
        /// <summary>
        /// Gets fired when the MovedElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MovedElementChanged;
        
        /// <summary>
        /// Gets fired before the Origin property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OriginChanging;
        
        /// <summary>
        /// Gets fired when the Origin property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OriginChanged;
    }
}

