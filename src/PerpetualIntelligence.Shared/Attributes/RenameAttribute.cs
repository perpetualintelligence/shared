/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target should be renamed.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class RenameAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        public RenameAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}
