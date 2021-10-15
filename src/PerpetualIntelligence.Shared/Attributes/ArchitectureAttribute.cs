/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target has an architectural comment that may be resolved in future releases. Applications can
    /// use the target element, but the design may change in future releases including breaking changes.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class ArchitectureAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">The description.</param>
        public ArchitectureAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// The description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The severity.
        /// </summary>
        public string? Severity { get; set; }

        /// <summary>
        /// The version to address the architecture comment.
        /// </summary>
        public string? Version { get; set; }
    }
}
