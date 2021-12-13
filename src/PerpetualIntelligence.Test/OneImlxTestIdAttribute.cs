/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a unique <c>OneImlx</c> test id.
    /// </summary>
    public sealed class OneImlxTestIdAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="id">The test id.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OneImlxTestIdAttribute(string id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// The test id.
        /// </summary>
        public string Id { get; set; }
    }
}
