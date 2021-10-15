/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target has a redundancy that can be resolved in future releases without any breaking changes.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class RedundancyAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        public RedundancyAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// The description.
        /// </summary>
        public string Description { get; set; }
    }
}
