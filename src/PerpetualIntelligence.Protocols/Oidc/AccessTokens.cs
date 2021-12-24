/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The access token types supported by the authorization server.
    /// </summary>
    public static class AccessTokens
    {
        /// <summary>
        /// Self-contained Json Web Token. A JWT token embeds identifiable information in the authorization response.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/info/rfc7519"/>
        public const string Jwt = "urn:oneimlx:oidc:at:jwt";

        /// <summary>
        /// Opaque tokens do not embed any identifiable information. The RP needs to call the OP that issued the token
        /// to check and use it further.
        /// </summary>
        public const string Opaque = "urn:oneimlx:oidc:at:opaque";
    }
}
