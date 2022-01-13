/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a unique <c>OneImlx</c> test id.
    /// </summary>
    /// <remarks>
    /// <see cref="OneImlxTestIdAttribute"/> is part of the Perpetual Intelligence infrastructure. Please do not use it
    /// directly in your application code.
    /// </remarks>

    [InternalInfrastructure]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class OneImlxTestIdAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="id">The test id.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OneImlxTestIdAttribute(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException($"The OneImlx test '{nameof(id)}' cannot be null or whitespace.", nameof(id));
            }

            Id = id;
        }

        /// <summary>
        /// The test id.
        /// </summary>
        public string Id { get; set; }
    }
}
