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
        public const string ConsumerObjectId = "urn:oneimlx:claims:coid";

        /// <summary>
        /// Indicates an <c>acr</c> consumer claim.
        /// </summary>
        public const string ConsumerTenantId = "urn:oneimlx:claims:ctid";

        /// <summary>
        /// Indicates an <c>acr</c> provider claim.
        /// </summary>
        public const string ProviderTenantId = "urn:oneimlx:claims:rtid";

        /// <summary>
        /// Indicates an <c>acr</c> publisher claim.
        /// </summary>
        public const string PublisherTenantId = "urn:oneimlx:claims:ptid";
    }
}
