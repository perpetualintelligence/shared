/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// The well known header keys.
    /// </summary>
    public class HeaderKeys
    {
        /// <summary>
        /// The <c>x-oneimlx-app-id</c> header key.
        /// </summary>
        public const string AppId = "x-oneimlx-app-id";

        /// <summary>
        /// The <c>x-oneimlx-app-type</c> header key.
        /// </summary>
        public const string AppType = "x-oneimlx-app-type";

        /// <summary>
        /// The <c>x-oneimlx-login-sub</c> header key.
        /// </summary>
        public const string LoginSubject = "x-oneimlx-login-sub";

        /// <summary>
        /// The <c>x-oneimlx-login-oid</c> header key.
        /// </summary>
        public const string LoginObjectId = "x-oneimlx-login-oid";

        /// <summary>
        /// The <c>x-oneimlx-login-tid</c> header key.
        /// </summary>
        public const string LoginTenantId = "x-oneimlx-login-tid";
    }
}
