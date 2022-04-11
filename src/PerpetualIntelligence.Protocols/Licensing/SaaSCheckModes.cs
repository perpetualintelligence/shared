/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// Defines the standard SaaS check modes.
    /// </summary>
    public class SaaSCheckModes
    {
        /// <summary>
        /// Determines if the check mode is valid.
        /// </summary>
        /// <returns><c>true</c> if the plan is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string plan)
        {
            switch (plan)
            {
                case Online:
                case OnlineThenOffline:
                case Offline:
                case OfflineThenOnline:
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
        /// The license check is done offline via signed public keys. This is not yet supported.
        /// </summary>
        public const string Offline = "urn:oneimlx:lic:saascmode:offline";

        /// <summary>
        /// First check <see cref="Offline"/> then <see cref="Online"/>. This is not yet supported.
        /// </summary>
        public const string OfflineThenOnline = "urn:oneimlx:lic:saascmode:offthenon";

        /// <summary>
        /// The license check is done online via REST API.
        /// </summary>
        public const string Online = "urn:oneimlx:lic:saascmode:online";

        /// <summary>
        /// First check <see cref="Online"/> then <see cref="Offline"/>. This is not yet supported.
        /// </summary>
        public const string OnlineThenOffline = "urn:oneimlx:lic:saascmode:onthenoff";
    }
}
