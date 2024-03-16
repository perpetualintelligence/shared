/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Text.Json.Serialization;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The generic license file.
    /// </summary>
    public sealed class LicenseFile
    {
        /// <summary>
        /// The validation public key to check the license <see cref="Key"/>.
        /// </summary>
        [JsonPropertyName("validation_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ValidationKey { get; set; }

        /// <summary>
        /// The consumer tenant id.
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; } = "";

        /// <summary>
        /// The consumer tenant id.
        /// </summary>
        [JsonPropertyName("tenant_name")]
        public string TenantName { get; set; } = "";

        /// <summary>
        /// The key to check.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = "";

        /// <summary>
        /// The identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        /// <summary>
        /// The issued at timestamp.
        /// </summary>
        [JsonPropertyName("issued_at")]
        public DateTimeOffset IssuedAt { get; set; }

        /// <summary>
        /// The expiry at timestamp.
        /// </summary>
        [JsonPropertyName("expiry_at")]
        public DateTimeOffset ExpiryAt { get; set; }

        /// <summary>
        /// The mode.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; } = "";

        /// <summary>
        /// The deployment.
        /// </summary>
        [JsonPropertyName("deployment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Deployment { get; set; }
    }
}