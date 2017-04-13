//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Reliability;
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
using System.Linq;

namespace NMFExamples.Pcm.Seff.Seff_reliability
{
    
    
    /// <summary>
    /// The public interface for RecoveryAction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RecoveryAction))]
    [XmlDefaultImplementationTypeAttribute(typeof(RecoveryAction))]
    public interface IRecoveryAction : IModelElement, IAbstractInternalControlFlowAction
    {
        
        /// <summary>
        /// The primaryBehaviour__RecoveryAction property
        /// </summary>
        IRecoveryActionBehaviour PrimaryBehaviour__RecoveryAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The recoveryActionBehaviours__RecoveryAction property
        /// </summary>
        IListExpression<IRecoveryActionBehaviour> RecoveryActionBehaviours__RecoveryAction
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the PrimaryBehaviour__RecoveryAction property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PrimaryBehaviour__RecoveryActionChanging;
        
        /// <summary>
        /// Gets fired when the PrimaryBehaviour__RecoveryAction property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PrimaryBehaviour__RecoveryActionChanged;
    }
}
