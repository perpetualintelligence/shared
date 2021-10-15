/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The access token types supported by the authorization server.
    /// </summary>
    public static class AccessTokens
    {
        /// <summary>
        /// Self-contained Json Web Token. A JWT token embeds identifiable information in the authorization response. See <see href="https://datatracker.ietf.org/doc/html/rfc7519"/> for more information.
        /// </summary>
        public const string Jwt = "urn:pi:protocols:oidc:at:jwt";

        /// <summary>
        /// Opaque token that do not embed any identifiable information.
        /// </summary>
        public const string Opaque = "urn:pi:protocols:oidc:at:opaque";
    }
}
