/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace OneImlx.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target has an architectural comment that may be resolved in future releases. Applications can
    /// use the target element, but the design may change in future releases including breaking changes.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class ArchitectureAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">The description.</param>
        public ArchitectureAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}
