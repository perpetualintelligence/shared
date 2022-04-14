/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// The header keys.
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
        /// The <c>x-oneimlx-login-objectid</c> header key.
        /// </summary>
        public const string LoginObjectId = "x-oneimlx-login-object-id";

        /// <summary>
        /// The <c>x-oneimlx-login-tenantid</c> header key.
        /// </summary>
        public const string LoginTenantId = "x-oneimlx-login-tenant-id";
    }
}
