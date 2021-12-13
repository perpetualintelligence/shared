/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The client assertion frameworks for OAuth or OpenID Connect client authentication.
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"></seealso>
    public static class ClientAssertions
    {
        /// <summary>
        /// JSON Web Token (JWT) Profile for OAuth 2.0 Client Authentication and Authorization Grants.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7523">
        /// JSON Web Token (JWT) Profile for OAuth 2.0 Client Authentication and Authorization Grants.
        /// </seealso>
        public const string JwtBearer = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";

        /// <summary>
        /// Security Assertion Markup Language (SAML) 2.0 Profile for OAuth 2.0 Client Authentication and Authorization Grants.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7522">
        /// Security Assertion Markup Language (SAML) 2.0 Profile for OAuth 2.0 Client Authentication and Authorization Grants.
        /// </seealso>
        public const string SamlBearer = "urn:ietf:params:oauth:client-assertion-type:saml2-bearer";
    }
}
