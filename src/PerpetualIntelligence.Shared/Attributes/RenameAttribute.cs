/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target should be renamed.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class RenameAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public RenameAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        public RenameAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// The description.
        /// </summary>
        public string? Description { get; set; }
    }
}
