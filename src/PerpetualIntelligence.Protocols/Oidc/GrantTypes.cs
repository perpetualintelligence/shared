/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The grant types for the OpenID Connect authentication protocol.
    /// </summary>
    public static class GrantTypes
    {
        /// <summary>
        /// The authorization code grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-1.3.1">Authorization Code</seealso>
        public const string AuthorizationCode = "authorization_code";

        /// <summary>
        /// The client credential grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.4">Client Credentials Grant</seealso>
        public const string ClientCredentials = "client_credentials";

        /// <summary>
        /// The device authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628">OAuth 2.0 Device Authorization Grant</seealso>
        public const string DeviceCode = "urn:ietf:params:oauth:grant-type:device_code";

        /// <summary>
        /// The hybrid grant.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#HybridFlowAuth">
        /// Authentication using the Hybrid Flow
        /// </seealso>
        public const string Hybrid = "hybrid";

        /// <summary>
        /// The implicit grant.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/html/rfc6749#section-1.3.2">Implicit</seealso>
        [Obsolete("Implicit flow is obsolete. Public clients such as native apps and JavaScript apps should now use the authorization code flow with the PKCE extension.")]
        public const string Implicit = "implicit";

        /// <summary>
        /// The JSON Web Token (JWT) Profile Client authentication and authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7523">
        /// JSON Web Token (JWT) Profile for OAuth 2.0 Client Authentication and Authorization Grants
        /// </seealso>
        public const string JwtBearer = "urn:ietf:params:oauth:grant-type:jwt-bearer";

        /// <summary>
        /// The resource owner password grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-1.3.3">Resource Owner Password Credentials</seealso>
        public const string ResourceOwnerPassword = "password";

        /// <summary>
        /// The refresh token grant.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/html/rfc6749#section-1.5">Refresh Token</seealso>
        public const string RefreshToken = "refresh_token";

        /// <summary>
        /// The SAML 2.0 profile for OAuth 2.0 client authenticaiton and authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/draft-ietf-oauth-saml2-bearer">
        /// SAML 2.0 Bearer Assertion Profiles for OAuth 2.0
        /// </seealso>
        public const string Saml2Bearer = "urn:ietf:params:oauth:grant-type:saml2-bearer";

        /// <summary>
        /// The OAuth 2.0 token exchange grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693">OAuth 2.0 Token Exchange</seealso>
        public const string TokenExchange = "urn:ietf:params:oauth:grant-type:token-exchange";

        /// <summary>
        /// All the supported OpenID Connect grant types.
        /// </summary>
        /// <returns></returns>
        public static string[] Oidc()
        {
            return new string[] {
                Implicit,
                Hybrid,
                AuthorizationCode,
                ClientCredentials,
                ResourceOwnerPassword,
                DeviceCode
            };
        }
    }
}
