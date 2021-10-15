/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element represents a concept.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class ConceptAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ConceptAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public ConceptAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// Additional description.
        /// </summary>
        public string? Description { get; set; }
    }
}
