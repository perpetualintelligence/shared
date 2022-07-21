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
        /// Returns the <c>MSAL B2C</c> based issuer.
        /// </summary>
        /// <param name="tenantName">The B2C tenant name.</param>
        /// <param name="tenantId">The B2C tenant id.</param>
        public static string B2CIssuer(string tenantName, string tenantId)
        {
            return string.Format(IssuerB2C, tenantName, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL B2C</c> based OpenID Connect configuration.
        /// </summary>
        /// <param name="tenantName">The B2C tenant name.</param>
        /// <param name="policy">The B2C policy.</param>
        public static string B2COpenIdConfiguration(string tenantName, string policy)
        {
            return string.Format(OpenIdConfigurationB2C, tenantName, policy);
        }

        /// <summary>
        /// Returns the <c>MSAL</c> tenant based issuer.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string TenantIssuer(string tenantId)
        {
            return string.Format(Issuer, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL</c> tenant based OpenID Connect configuration.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string TenantOpenIdConfiguration(string tenantId)
        {
            return string.Format(OpenIdConfiguration, tenantId);
        }

        /// <summary>
        /// The <c>MSAL</c> V2 Issuer.
        /// </summary>
        public const string Issuer = "https://login.microsoftonline.com/{0}/v2.0";

        /// <summary>
        /// The <c>MSAL</c> B2C V2 authority.
        /// </summary>
        public const string IssuerB2C = "https://{0}.b2clogin.com/{1}/v2.0/";

        /// <summary>
        /// The <c>MSAL</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string OpenIdConfiguration = "https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration";

        /// <summary>
        /// The <c>MSAL B2C</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string OpenIdConfigurationB2C = "https://{0}.b2clogin.com/{0}.onmicrosoft.com/{1}/v2.0/.well-known/openid-configuration";
    }
}
