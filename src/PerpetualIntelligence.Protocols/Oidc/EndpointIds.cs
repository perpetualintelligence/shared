/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>oneimlx</c> endpoint identifiers for OAuth and OpenID Connect protocols.
    /// </summary>
    /// <seealso cref="EndpointNames"/>
    public static class EndpointIds
    {
        /// <summary>
        /// The <c>authorize</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.2.1"/>
        public const string Authorize = "urn:oneimlx:auth";

        /// <summary>
        /// The <c>check_session</c> or <c>check_session_iframe</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-session-1_0.html"/>
        public const string CheckSession = "urn:oneimlx:checksession";

        /// <summary>
        /// The <c>device_authorization</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
        public const string DeviceAuthorization = "urn:oneimlx:device";

        /// <summary>
        /// The <c>discovery</c> or <c>.well-known</c> configuration.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-discovery-1_0.html"/>
        public const string Discovery = "urn:oneimlx:discovery";

        /// <summary>
        /// The <c>end_session</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-session-1_0.html"/>
        public const string EndSession = "urn:oneimlx:endsession";

        /// <summary>
        /// The token introspection or <c>introspect</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7662#section-2"/>
        public const string Introspect = "urn:oneimlx:introspect";

        /// <summary>
        /// The json web keys or <c>jwks</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7517"/>
        public const string Jwks = "urn:oneimlx:jwks";

        /// <summary>
        /// The token revocation or <c>revoke</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009#section-2.1"/>
        public const string Revoke = "urn:oneimlx:revoke";

        /// <summary>
        /// The <c>token</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.2"/>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#HybridTokenEndpoint"/>
        public const string Token = "urn:oneimlx:token";

        /// <summary>
        /// The <c>user_info</c> or <c>userinfo</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#UserInfo"/>
        public const string UserInfo = "urn:oneimlx:userinfo";
    }
}
