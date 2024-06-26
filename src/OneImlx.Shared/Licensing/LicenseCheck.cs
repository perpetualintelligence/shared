﻿/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The license check.
    /// </summary>
    public sealed class LicenseCheck
    {
        /// <summary>
        /// The audience.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; } = "";

        /// <summary>
        /// The Authorized application.
        /// </summary>
        [JsonPropertyName("application")]
        public string Application { get; set; } = "";

        /// <summary>
        /// The Authorized party.
        /// </summary>
        [JsonPropertyName("authorized_party")]
        public string AuthorizedParty { get; set; } = "";

        /// <summary>
        /// The consumer tenant id.
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; } = "";

        /// <summary>
        /// The issuer.
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; } = "";

        /// <summary>
        /// The key to check.
        /// </summary>
        [JsonPropertyName("lkey")]
        public string LicenseKey { get; set; } = "";

        /// <summary>
        /// The license identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        /// <summary>
        /// The validation public key to check the license <see cref="LicenseKey"/>.
        /// </summary>
        [JsonPropertyName("vkey")]
        public string? ValidationKey { get; set; }

        /// <summary>
        /// The license mode.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; } = "";

        /// <summary>
        /// The license mode.
        /// </summary>
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
    }
}