/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace OneImlx.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element requires documentation.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class WriteDocumentationAttribute : ActionAttribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public WriteDocumentationAttribute() : base()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public WriteDocumentationAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}
