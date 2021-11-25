/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    /// <summary>
    /// Represents a protected string or a protected key extracted from a context.
    /// </summary>
    /// <seealso cref="Secret"/>
    /// <seealso cref="SecretTypes"/>
    /// <seealso cref="SecretComparer"/>
    [Concept("Secrets Manager")]
    [ToUnitTest]
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
