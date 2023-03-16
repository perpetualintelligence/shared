/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Authorization
{
    /// <summary>
    /// The authorization policies.
    /// </summary>
    public class Policies
    {
        /// <summary>
        /// User authenticated policy.
        /// </summary>
        public const string Authenticated = "urn:oneimlx:policies:authenticated";

        /// <summary>
        /// Consumer portal authorization policy.
        /// </summary>
        public const string Consumer = "urn:oneimlx:policies:consumer";

        /// <summary>
        /// Publisher portal authorization policy.
        /// </summary>
        public const string Publisher = "urn:oneimlx:policies:publisher";
    }
}
