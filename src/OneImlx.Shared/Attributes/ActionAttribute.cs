/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace OneImlx.Shared.Attributes
{
    /// <summary>
    /// An actionable attribute.
    /// </summary>
    public abstract class ActionAttribute : Attribute
    {
        /// <summary>
        /// The action assignee.
        /// </summary>
        public string? Assignee { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The severity.
        /// </summary>
        public string? Severity { get; set; }

        /// <summary>
        /// The version to address an action.
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        protected ActionAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected ActionAttribute(string description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
