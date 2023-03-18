/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element should have unit tests.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class WriteUnitTestAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public WriteUnitTestAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance with description.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public WriteUnitTestAttribute(string description) : base(description)
        {
        }
    }
}
