/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Licensing.Models
{
    /// <summary>
    /// The license provisioning model.
    /// </summary>
    public class LicenseProvisioningModel
    {
        /// <summary>
        /// The <c>acr</c> claim.
        /// </summary>
        [JsonPropertyName("acr_values")]
        public string[] AcrValues { get; set; } = null!;

        /// <summary>
        /// The <c>auth_apps</c> claim.
        /// </summary>
        [JsonPropertyName("authorized_applications")]
        public string[] AuthorizedApplications { get; set; } = null!;

        /// <summary>
        /// The <c>azp</c> claim.
        /// </summary>
        [JsonPropertyName("authorized_party")]
        public string AuthorizedParty { get; set; } = null!;

        /// <summary>
        /// The consumer tenant id. This is the <c>tid</c> claim.
        /// </summary>
        [JsonPropertyName("consumer_tenant_country")]
        public string? ConsumerTenantCountry { get; set; }

        /// <summary>
        /// The consumer tenant id. This is the <c>tid</c> claim.
        /// </summary>
        [JsonPropertyName("consumer_tenant_id")]
        public string ConsumerTenantId { get; set; } = null!;

        /// <summary>
        /// The consumer tenant id. This is the <c>tid</c> claim.
        /// </summary>
        [JsonPropertyName("consumer_tenant_name")]
        public string? ConsumerTenantName { get; set; }

        /// <summary>
        /// The jws key expiry.
        /// </summary>
        [JsonPropertyName("expiry")]
        public DateTimeOffset Expiry { get; set; }

        /// <summary>
        /// The space separated keys operations. Valid value is <c>actions</c>, <c>get</c>, <c>generate</c>,
        /// <c>reset_primary</c>, <c>reset_secondary</c> and <c>delete</c>.
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; } = null!;

        /// <summary>
        /// The provider tenant id.
        /// </summary>
        [JsonPropertyName("provider_tenant_id")]
        public string ProviderTenantId { get; set; } = null!;

        /// <summary>
        /// The <c>sub</c> claim.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; } = null!;
    }
}
