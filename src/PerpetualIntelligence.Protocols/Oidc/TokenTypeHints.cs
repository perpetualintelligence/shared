/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect token type hints.
    /// </summary>
    [MustDo("Why do we need this ? Why cant we just use the Tokens ? Does that make the URL long ?")]
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
