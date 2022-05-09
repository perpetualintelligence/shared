/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The license usage.
    /// </summary>
    public class LicenseUsages
    {
        /// <summary>
        /// Determines if the usage is valid.
        /// </summary>
        /// <returns><c>true</c> if the usage is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string usage)
        {
            switch (usage)
            {
                case CommercialPersonal:
                case CommercialBusiness:
                case Educational:
                case RnD:
                case None:
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
        /// The neutral or no license usage plan.
        /// </summary>
        public const string None = "urn:oneimlx:lic:usage:none";

        /// <summary>
        /// The commercial usage for an organization or business account.
        /// </summary>
        public const string CommercialBusiness = "urn:oneimlx:lic:usage:org";

        /// <summary>
        /// The commercial usage for a personal or social account.
        /// </summary>
        public const string CommercialPersonal = "urn:oneimlx:lic:usage:per";

        /// <summary>
        /// The community usage for educational account.
        /// </summary>
        public const string Educational = "urn:oneimlx:lic:usage:edu";

        /// <summary>
        /// The community test and demo usage for any account.
        /// </summary>
        public const string RnD = "urn:oneimlx:lic:usage:rnd";
    }
}
