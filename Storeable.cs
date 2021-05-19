// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Storeable.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Storeable type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Interview
{
    using System;

    /// <summary>
    /// The storeable.
    /// </summary>
    public class Storeable : IStoreable
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public IComparable Id { get; set; }
    }
}
