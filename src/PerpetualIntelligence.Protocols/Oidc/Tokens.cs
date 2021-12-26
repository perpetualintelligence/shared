/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The token types in the OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"></seealso>
    public static class Tokens
    {
        /// <summary>
        /// Indicates that the token is an OAuth 2.0 access token issued by the authorization server.
        /// </summary>
        public const string AccessToken = "urn:ietf:params:oauth:token-type:access_token";

        /// <summary>
        /// Indicates that the token is an ID Token issued by the authorization server.
        /// </summary>
        public const string IdToken = "urn:ietf:params:oauth:token-type:id_token";

        /// <summary>
        /// Indicates that the token is a JWT.
        /// </summary>
        public const string Jwt = "urn:ietf:params:oauth:token-type:jwt";

        /// <summary>
        /// Indicates that the token is an OAuth 2.0 refresh token issued by the authorization server.
        /// </summary>
        public const string RefreshToken = "urn:ietf:params:oauth:token-type:refresh_token";

        /// <summary>
        /// Indicates that the token is a base64url-encoded SAML 1.1.
        /// </summary>
        public const string Saml1 = "urn:ietf:params:oauth:token-type:saml1";

        /// <summary>
        /// Indicates that the token is a base64url-encoded SAML 2.0.
        /// </summary>
        public const string Saml2 = "urn:ietf:params:oauth:token-type:saml2";
    }
}
