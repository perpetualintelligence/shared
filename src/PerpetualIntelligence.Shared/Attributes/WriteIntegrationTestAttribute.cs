/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element should have integration tests.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class WriteIntegrationTestAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public WriteIntegrationTestAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance with description.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public WriteIntegrationTestAttribute(string description) : base(description)
        {
        }
    }
}
