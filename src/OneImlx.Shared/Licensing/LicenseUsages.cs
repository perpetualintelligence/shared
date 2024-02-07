/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace OneImlx.Shared.Licensing
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
                case CommercialSolo:
                case CommercialBusiness:
                case Educational:
                case RnD:
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
        /// The commercial usage for an organization or business account.
        /// </summary>
        public const string CommercialBusiness = "urn:oneimlx:lic:usage:org";

        /// <summary>
        /// The commercial usage for a personal or social account.
        /// </summary>
        public const string CommercialSolo = "urn:oneimlx:lic:usage:solo";

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