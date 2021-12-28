/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
