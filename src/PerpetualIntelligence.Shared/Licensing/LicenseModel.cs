/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Licensing
{
    /// <summary>
    /// The generic license.
    /// </summary>
    public sealed class LicenseModel
    {
        /// <summary>
        /// The validation public key to check the license.
        /// </summary>
        [JsonPropertyName("validation_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ValidationKey { get; set; }

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
        /// The consumer object id.
        /// </summary>
        [JsonPropertyName("consumer_object_id")]
        public string? ConsumerObjectId { get; set; }

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
        [JsonPropertyName("broker_tenant_id")]
        public string BrokerTenantId { get; set; } = null!;

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
        /// The license key status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The subject. This is also the <c>sub</c> claim.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; } = null!;
    }
}