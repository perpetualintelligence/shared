/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Abstractions.Stores
{
    /// <summary>
    /// An abstraction of a multi-tenant entity that establishes a commercial relationship between businesses, precisely
    /// provider and consumer. It is a typical model when a business or a company sells its products or services
    /// directly to other companies. The customers of a product or service are the users, collaborators, or employees
    /// within the consumer business.
    /// </summary>
    public interface IMarketplaceEntity
    {
        /// <summary>
        /// The consumer tenant id.
        /// </summary>
        public string ConsumerTenantId { get; set; }

        /// <summary>
        /// The provider tenant id.
        /// </summary>
        public string ProviderTenantId { get; set; }

        /// <summary>
        /// The publisher tenant id.
        /// </summary>
        public string PublisherTenantId { get; set; }
    }
}
