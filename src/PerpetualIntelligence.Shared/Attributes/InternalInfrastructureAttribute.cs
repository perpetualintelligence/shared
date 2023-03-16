/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target is part of the internal infrastructure. Application should not use the target directly.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class InternalInfrastructureAttribute : Attribute
    {
        /// <summary>
        /// Additional description.
        /// </summary>
        public string? Description { get; set; }
    }
}
