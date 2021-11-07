/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates a MUST-DO action on the target element.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class MustDoAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public MustDoAttribute(string description) : base(description)
        {
            Description = description;
        }

        /// <summary>
        /// This indicates that DevOps should block the package release until the MUST-DO action is open.
        /// </summary>
        /// <remarks>
        /// You should write tests that execute only in your DevOps release environment and check for this attribute.
        /// </remarks>
        public bool BlockRelease { get; set; }
    }
}