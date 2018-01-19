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
    /// The public interface for AttributeConstraint
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AttributeConstraint))]
    [XmlDefaultImplementationTypeAttribute(typeof(AttributeConstraint))]
    public interface IAttributeConstraint : NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The Values property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        IListExpression<string> Values
        {
            get;
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AttributeConstraints")]
        IClass DeclaringType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Constrains property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IAttribute Constrains
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired before the Constrains property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstrainsChanging;
        
        /// <summary>
        /// Gets fired when the Constrains property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstrainsChanged;
    }
}

