/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The standard license providers.
    /// </summary>
    public sealed class LicenseProviders
    {
        /// <summary>
        /// Determines if the provider is valid.
        /// </summary>
        /// <returns><c>true</c> if the plan is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string pvdr)
        {
            switch (pvdr)
            {
                case PerpetualIntelligence:
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        /// <summary>
        /// The registered licensing provider hosted by <c>Perpetual Intelligence L.L.C.</c>
        /// </summary>
        public const string PerpetualIntelligence = "urn:oneimlx:lic:pvdr:pi";
    }
}