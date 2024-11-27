/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace OneImlx.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target is part of the internal infrastructure. Application should not use the target directly.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class InternalInfrastructureAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public InternalInfrastructureAttribute(string? description = null)
        {
        }

        /// <summary>
        /// Additional description.
        /// </summary>
        public string? Description { get; set; }
    }
}
