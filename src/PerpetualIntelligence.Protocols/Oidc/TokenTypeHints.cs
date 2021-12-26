/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect token type hints.
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009"/>
    public static class TokenTypeHints
    {
        /// <summary>
        /// The <c>access_token</c>.
        /// </summary>
        public const string AccessToken = "access_token";

        /// <summary>
        /// The <c>id_token</c>.
        /// </summary>
        public const string IdToken = "id_token";

        /// <summary>
        /// The <c>refresh_token</c>.
        /// </summary>
        public const string RefreshToken = "refresh_token";
    }
}
