/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The SaaS usage.
    /// </summary>
    public class SaaSUsage
    {

        /// <summary>
        /// Determines if the usage is valid.
        /// </summary>
        /// <returns><c>true</c> if the usage is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string usage)
        {
            switch (usage)
            {
                case Commercial:
                case Educational:
                case Test:
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
        /// The community SaaS pricing plan.
        /// </summary>
        public const string Commercial = "urn:oneimlx:lic:saasusage:commerce";

        /// <summary>
        /// The community SaaS pricing plan.
        /// </summary>
        public const string Educational = "urn:oneimlx:lic:saasusage:edu";

        /// <summary>
        /// The community SaaS pricing plan.
        /// </summary>
        public const string Test = "urn:oneimlx:lic:saasusage:test";
    }
}
