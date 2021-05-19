// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStoreable.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IStoreable type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Interview
{
    using System;

    /// <summary>
    /// The Storeable interface.
    /// </summary>
    public interface IStoreable
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        IComparable Id { get; set; }
    }
    
}