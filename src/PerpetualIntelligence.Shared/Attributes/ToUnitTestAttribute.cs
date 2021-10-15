/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element should have unit tests.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class ToUnitTestAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public ToUnitTestAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance with description.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public ToUnitTestAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// Additional description.
        /// </summary>
        public string? Description { get; set; }
    }
}
