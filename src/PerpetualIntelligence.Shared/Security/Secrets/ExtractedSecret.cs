/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Security.Secrets
{
    /// <summary>
    /// Represents a protected string or a protected key extracted from a context.
    /// </summary>
    /// <seealso cref="Secret"/>
    /// <seealso cref="SecretTypes"/>
    /// <seealso cref="SecretComparer"/>
    public sealed class ExtractedSecret
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
