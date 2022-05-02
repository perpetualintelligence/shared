/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// The <c>MSAL</c> authorization endpoints.
    /// </summary>
    public static class MsalEndpoints
    {
        /// <summary>
        /// Returns the <c>MSAL</c> tenant authority.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string TenantAuthority(string tenantId)
        {
            return string.Format(Authority, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL</c> tenant OpenID Connect configuration.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string TenantOpenIdConfiguration(string tenantId)
        {
            return string.Format(OpenIdConfiguration, tenantId);
        }

        /// <summary>
        /// The <c>MSAL</c> V2 authority.
        /// </summary>
        public const string Authority = "https://login.microsoftonline.com/{0}/v2.0";

        /// <summary>
        /// The <c>MSAL</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string OpenIdConfiguration = "https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration";
    }
}
