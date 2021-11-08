/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    /// <summary>
    /// Specifies the allowed string values on the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class SelectItemAttribute : Attribute
    {
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public SelectItemAttribute(string name, string? value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Item display description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Item disability.
        /// </summary>
        public bool Disabled { get; }

        /// <summary>
        /// Item display name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Item value.
        /// </summary>
        public string? Value { get; }

        /// <summary>
        /// The item value is obsolete.
        /// </summary>
        public bool Obsolete { get; set; }
    }
}
