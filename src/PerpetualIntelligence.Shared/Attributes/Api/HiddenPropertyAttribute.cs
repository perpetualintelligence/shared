/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Attributes.Api
{
    /// <summary>
    /// Hides the target property from the API spec.
    /// </summary>
    /// <remarks>
    /// The property marked as <see cref="JsonIgnoreAttribute"/> may be visible in the API spec generator such as
    /// Swagger UI. Use this attribute to process and remove the property from your API spec schema.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class HiddenPropertyAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="property">The property to hide.</param>
        /// <param name="justification">The justification to hide the property.</param>
        public HiddenPropertyAttribute(string property, string justification)
        {
            Property = property;
            Justification = justification;
        }

        /// <summary>
        /// The justification to hide the property.
        /// </summary>
        public string Justification { get; }

        /// <summary>
        /// The property to hide.
        /// </summary>
        public string Property { get; }
    }
}
