/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// The well known claims.
    /// </summary>
    public class ClaimTypes
    {
        /// <summary>
        /// Indicates an <c>acr</c> consumer claim.
        /// </summary>
        public const string ConsumerObjectId = "extension_CustomConsumerObjectId";

        /// <summary>
        /// Indicates an <c>acr</c> consumer claim.
        /// </summary>
        public const string ConsumerTenantId = "extension_CustomConsumerTenantId";

        /// <summary>
        /// Indicates an <c>acr</c> marketplace resolved claim.
        /// </summary>
        public const string MarketplaceResolved = "extension_CustomMarketplaceResolved";

        /// <summary>
        /// Indicates an <c>acr</c> provider claim.
        /// </summary>
        public const string ProviderTenantId = "extension_CustomProviderTenantId";

        /// <summary>
        /// Indicates an <c>acr</c> publisher claim.
        /// </summary>
        public const string PublisherTenantId = "extension_CustomPublisherTenantId";
    }
}
