/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The <c>jws</c> B2B keys model.
    /// </summary>
    public class LicenseKeysModel
    {
        /// <summary>
        /// The <c>acr</c> claim.
        /// </summary>
        [JsonPropertyName("acr_values")]
        public string[] AcrValues { get; set; } = null!;

        /// <summary>
        /// The authorized application. This is also the <c>auth_apps</c> claim.
        /// </summary>
        [JsonPropertyName("authorized_application_ids")]
        public string[] AuthorizedApplicationIds { get; set; } = null!;

        /// <summary>
        /// The Authorized party. This is also the <c>azp</c> claim.
        /// </summary>
        [JsonPropertyName("authorized_party")]
        public string AuthorizedParty { get; set; } = null!;

        /// <summary>
        /// The consumer tenant id.
        /// </summary>
        [JsonPropertyName("consumer_tenant_id")]
        public string ConsumerTenantId { get; set; } = null!;

        /// <summary>
        /// The consumer tenant name.
        /// </summary>
        [JsonPropertyName("consumer_tenant_name")]
        public string? ConsumerTenantName { get; set; }

        /// <summary>
        /// The etag.
        /// </summary>
        [JsonPropertyName("etag")]
        public string Etag { get; set; } = null!;

        /// <summary>
        /// The expires in days.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// The operations available for clients.
        /// </summary>
        [JsonPropertyName("operations")]
        public string[] Operations { get; set; } = null!;

        /// <summary>
        /// The primary <c>jwt</c> license key.
        /// </summary>
        [JsonPropertyName("primary_key")]
        public string PrimaryKey { get; set; } = null!;

        /// <summary>
        /// The registered provider or provider tenant id.
        /// </summary>
        [JsonPropertyName("provider_tenant_id")]
        public string ProviderTenantId { get; set; } = null!;

        /// <summary>
        /// The publisher tenant id.
        /// </summary>
        [JsonPropertyName("publisher_tenant_id")]
        public string PublisherTenantId { get; set; } = null!;

        /// <summary>
        /// The secondary <c>jwt</c> license key. Use this key when rotating the primary key.
        /// </summary>
        [JsonPropertyName("secondary_key")]
        public string SecondaryKey { get; set; } = null!;

        /// <summary>
        /// The subject. This is also the <c>sub</c> claim.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; } = null!;
    }
}
