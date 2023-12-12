/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The  license providers.
    /// </summary>
    public sealed class LicenseProviders
    {
        /// <summary>
        /// Determines if the provider is valid.
        /// </summary>
        /// <param name="pvdr">The license provider id.</param>
        /// <returns><c>true</c> if the plan is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string pvdr)
        {
            switch (pvdr)
            {
                case OneImlx:
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
        public const string OneImlx = "urn:oneimlx:lic:pvdr:pi";
    }
}