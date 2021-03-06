//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.SystemIndependent;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.Assembly
{
    
    
    /// <summary>
    /// The public interface for DelegateConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DelegateConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(DelegateConnector))]
    public interface IDelegateConnector : IModelElement
    {
        
        /// <summary>
        /// The Interface property
        /// </summary>
        IInterface Interface
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConnectedAssemblyContext property
        /// </summary>
        IAssemblyContext ConnectedAssemblyContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Interface property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> InterfaceChanging;
        
        /// <summary>
        /// Gets fired when the Interface property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> InterfaceChanged;
        
        /// <summary>
        /// Gets fired before the ConnectedAssemblyContext property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ConnectedAssemblyContextChanging;
        
        /// <summary>
        /// Gets fired when the ConnectedAssemblyContext property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ConnectedAssemblyContextChanged;
    }
}

