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
