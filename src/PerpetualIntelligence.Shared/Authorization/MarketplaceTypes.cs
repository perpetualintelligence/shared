/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Authorization
{
    /// <summary>
    /// The well-known marketplace types.
    /// </summary>
    public class MarketplaceTypes
    {
        /// <summary>
        /// The AWS commercial marketplace.
        /// </summary>
        public const string Aws = "urn:oneimlx:mkt:aws";

        /// <summary>
        /// The Microsoft commercial marketplace.
        /// </summary>
        public const string Microsoft = "urn:oneimlx:mkt:ms";

        /// <summary>
        /// The Stripe commercial marketplace.
        /// </summary>
        public const string Stripe = "urn:oneimlx:mkt:stripe";
    }
}
