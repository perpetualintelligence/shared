﻿/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace OneImlx.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element should have integration tests.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class WriteIntegrationTestAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance with description.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public WriteIntegrationTestAttribute(string description) : base(description)
        {
        }
    }
}
