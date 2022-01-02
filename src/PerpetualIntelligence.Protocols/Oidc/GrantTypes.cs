/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
        /// All the supported OpenID Connect grant types.
        /// </summary>
        /// <returns></returns>
        public static string[] Oidc()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            return new string[] {
                Implicit,
                Hybrid,
                AuthorizationCode,
                ClientCredentials,
                ResourceOwnerPassword,
                DeviceCode
            };
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// The authorization code grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-1.3.1"></seealso>
        public const string AuthorizationCode = "authorization_code";

        /// <summary>
        /// The client credential grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.4"></seealso>
        public const string ClientCredentials = "client_credentials";

        /// <summary>
        /// The device authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"></seealso>
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
        /// <remarks>
        /// Implicit flow is obsolete. Public clients such as native apps and JavaScript apps should now use the
        /// authorization code flow with the PKCE extension.
        /// </remarks>
        /// <seealso href="https://tools.ietf.org/html/rfc6749#section-1.3.2"></seealso>
        [Obsolete("Implicit flow is obsolete. Public clients such as native apps and JavaScript apps should now use the authorization code flow with the PKCE extension.")]
        public const string Implicit = "implicit";

        /// <summary>
        /// The JSON Web Token (JWT) Profile Client authentication and authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7523"></seealso>
        public const string JwtBearer = "urn:ietf:params:oauth:grant-type:jwt-bearer";

        /// <summary>
        /// The refresh token grant.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/html/rfc6749#section-1.5">Refresh Token</seealso>
        public const string RefreshToken = "refresh_token";

        /// <summary>
        /// The resource owner password grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-1.3.3">Resource Owner Password Credentials</seealso>
        public const string ResourceOwnerPassword = "password";

        /// <summary>
        /// The SAML 2.0 profile for OAuth 2.0 client authentication and authorization grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/draft-ietf-oauth-saml2-bearer"></seealso>
        public const string Saml2Bearer = "urn:ietf:params:oauth:grant-type:saml2-bearer";

        /// <summary>
        /// The OAuth 2.0 token exchange grant.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"></seealso>
        public const string TokenExchange = "urn:ietf:params:oauth:grant-type:token-exchange";
    }
}
