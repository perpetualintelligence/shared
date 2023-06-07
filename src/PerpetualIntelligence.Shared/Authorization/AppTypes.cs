/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Authorization
{
    /// <summary>
    /// The well-known app types.
    /// </summary>
    public class AppTypes
    {
        /// <summary>
        /// The cli application.
        /// </summary>
        public const string CliApplication = "urn:oneimlx:apps:cliapp";

        /// <summary>
        /// The consumer portal.
        /// </summary>
        public const string ConsumerPortal = "urn:oneimlx:apps:consumerportal";

        /// <summary>
        /// The publisher portal.
        /// </summary>
        public const string PublisherPortal = "urn:oneimlx:apps:publisherportal";

        /// <summary>
        /// The publisher portal.
        /// </summary>
        public const string Undefined = "urn:oneimlx:apps:undefined";

        /// <summary>
        /// The client portal.
        /// </summary>
        public const string Client = "urn:oneimlx:apps:client";
    }
}
