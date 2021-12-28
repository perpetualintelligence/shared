/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    /// <summary>
    /// Represents a protected string or a protected key extracted from a context.
    /// </summary>
    /// <seealso cref="Secret"/>
    /// <seealso cref="SecretTypes"/>
    /// <seealso cref="SecretComparer"/>
    public sealed class ExtractedSecret : OneImlxResult
    {
        /// <summary>
        /// The secret identifier.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// The secret type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// The secret value.
        /// </summary>
        public object? Value { get; set; }
    }
}
