/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols
{
    /// <summary>
    /// Defines the supported protocols.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The Perpetual Intelligence's <c>cli</c> protocol.
        /// </summary>
        public const string Cli = "urn:oneimlx:cli";

        /// <summary>
        /// The <c>OAuth</c> 2.0 authorization protocol.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749"/>
        public const string OAuth2 = "OAuth2.0";

        /// <summary>
        /// The Perpetual Intelligence's <c>oneimlx</c> protocol.
        /// </summary>
        public const string OneImlx = "urn:oneimlx";

        /// <summary>
        /// The Perpetual Intelligence's <c>oneimlx</c> extension for <c>OAuth 2.0</c> authorization protocol.
        /// </summary>
        public const string OneImlxOAuth2 = "urn:oneimlx:oauth2";

        /// <summary>
        /// The Perpetual Intelligence's <c>oneimlx</c> extension for <c>OpenID Connect</c> authentication protocol.
        /// </summary>
        public const string OneImlxOidc = "urn:oneimlx:oidc";

        /// <summary>
        /// The <c>OpenID Connect</c> authentication protocol.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string OpenIDConnect = "oidc";

        /// <summary>
        /// The Web Services Federation protocol.
        /// </summary>
        /// <seealso href="http://docs.oasis-open.org/wsfed/federation/v1.2/os/ws-federation-1.2-spec-os.html"/>
        public const string WebServicesFederation = "wsfed";
    }
}
