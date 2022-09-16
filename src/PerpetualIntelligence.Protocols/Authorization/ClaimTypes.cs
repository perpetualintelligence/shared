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
        /// Indicates an <c>extension_CustomBrokerTenantId</c> provider tenant claim.
        /// </summary>
        public const string BrokerTenantId = "extension_CustomBrokerTenantId";

        /// <summary>
        /// Indicates an <c>extension_CustomConsumerObjectId</c> consumer object claim.
        /// </summary>
        public const string ConsumerObjectId = "extension_CustomConsumerObjectId";

        /// <summary>
        /// Indicates an <c>extension_CustomConsumerTenantId</c> consumer tenant claim.
        /// </summary>
        public const string ConsumerTenantId = "extension_CustomConsumerTenantId";

        /// <summary>
        /// Indicates an <c>extension_CustomForceResolve</c> claim.
        /// </summary>
        public const string ForceResolve = "extension_CustomForceResolve";

        /// <summary>
        /// Indicates an <c>extension_CustomMarketplace</c> claim.
        /// </summary>
        public const string Marketplace = "extension_CustomMarketplace";

        /// <summary>
        /// Indicates an <c>extension_CustomMarketplaceResolved</c> marketplace resolved claim.
        /// </summary>
        public const string MarketplaceResolved = "extension_CustomMarketplaceResolved";

        /// <summary>
        /// Indicates an <c>extension_CustomPublisherTenantId</c> publisher tenant claim.
        /// </summary>
        public const string PublisherTenantId = "extension_CustomPublisherTenantId";

        /// <summary>
        /// Indicates an <c>extension_CustomResolvedSubscription</c> claim. It is the current resolved subscription.
        /// </summary>
        public const string ResolvedSubscription = "extension_CustomResolvedSubscription";
    }
}
