/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Authorization
{
    /// <summary>
    /// The <c>MSAL</c> authorization endpoints.
    /// </summary>
    public static class AuthEndpoints
    {
        // <summary>
        /// Returns the <c>Perpetual Intelligence B2C</c> based issuer.
        /// </summary>
        /// <param name="tenantName">The B2C tenant name.</param>
        /// <param name="tenantId">The B2C tenant id.</param>
        public static string PiB2CIssuer(string tenantId)
        {
            return string.Format(PiIssuerB2C, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL B2C</c> based issuer.
        /// </summary>
        /// <param name="tenantName">The B2C tenant name.</param>
        /// <param name="tenantId">The B2C tenant id.</param>
        public static string MsalB2CIssuer(string tenantName, string tenantId)
        {
            return string.Format(MsalIssuerB2C, tenantName, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL B2C</c> based OpenID Connect configuration.
        /// </summary>
        /// <param name="tenantName">The B2C tenant name.</param>
        /// <param name="policy">The B2C policy.</param>
        public static string MsalB2COpenIdConfiguration(string tenantName, string policy)
        {
            return string.Format(MsalOpenIdConfigurationB2C, tenantName, policy);
        }

        /// <summary>
        /// Returns the <c>MSAL</c> tenant based issuer.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string MsalTenantIssuer(string tenantId)
        {
            return string.Format(MsalIssuer, tenantId);
        }

        /// <summary>
        /// Returns the <c>MSAL</c> tenant based OpenID Connect configuration.
        /// </summary>
        /// <param name="tenantId">The tenant id.</param>
        public static string MsalTenantOpenIdConfiguration(string tenantId)
        {
            return string.Format(MsalOpenIdConfiguration, tenantId);
        }

        /// <summary>
        /// The <c>MSAL</c> V2 Issuer.
        /// </summary>
        public const string MsalIssuer = "https://login.microsoftonline.com/{0}/v2.0";

        /// <summary>
        /// The <c>MSAL</c> B2C V2 authority.
        /// </summary>
        public const string MsalIssuerB2C = "https://{0}.b2clogin.com/{1}/v2.0/";

        /// <summary>
        /// The <c>MSAL</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string MsalOpenIdConfiguration = "https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration";

        /// <summary>
        /// The <c>Perpetual Intelligence</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string PiIssuerB2C = "https://login.perpetualintelligence.com/{0}/v2.0";

        /// <summary>
        /// The <c>Perpetual Intelligence</c> B2C Tenant name.
        /// </summary>
        public const string PiB2CTenantName = "perpetualintelligenceb2c";

        /// <summary>
        /// The <c>MSAL B2C</c> V2 Open ID Connect configuration.
        /// </summary>
        public const string MsalOpenIdConfigurationB2C = "https://{0}.b2clogin.com/{0}.onmicrosoft.com/{1}/v2.0/.well-known/openid-configuration";
    }
}