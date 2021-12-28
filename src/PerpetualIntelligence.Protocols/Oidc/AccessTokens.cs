/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
