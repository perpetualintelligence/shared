/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Imlx;
using System.Security.Claims;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Well known constants for the OAuth or OpenID Connect authentication protocol.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The authentication type used to create the <see cref="ClaimsPrincipal"/>.
        /// </summary>
        public const string AuthenticationType = OrgConstants.Oidc + ":auth";

        /// <summary>
        /// The bearer token in authorization header.
        /// </summary>
        public const string AuthorizationHeaderBearer = "Bearer";

        /// <summary>
        /// The bearer token type.
        /// </summary>
        public const string BearerTokenType = "Bearer";

        /// <summary>
        /// The default CORS policy name.
        /// </summary>
        public const string CorsPolicyName = OrgConstants.ImlxOrg + ".Cors";

        /// <summary>
        /// The default <c>check_session</c> cookie name.
        /// </summary>
        public const string DefaultCheckSessionCookieName = OrgConstants.ImlxOrg + ".Cookie.Session";

        /// <summary>
        /// The default authentication cookie name.
        /// </summary>
        public const string DefaultCookieAuthenticationScheme = OrgConstants.ImlxOrg + ".Cookie.Auth";

        /// <summary>
        /// The default external authentication cookie name.
        /// </summary>
        public const string DefaultExternalCookieAuthenticationScheme = OrgConstants.ImlxOrg + ".Cookie.External";

        /// <summary>
        /// The <c>jwt</c> request key.
        /// </summary>
        public const string DefaultJwtRequestClientKey = OrgConstants.Oidc + ":scheme:jwt";

        /// <summary>
        /// The signout scheme.
        /// </summary>
        public const string DefaultSignoutScheme = OrgConstants.Oidc + ":scheme:signout";

        /// <summary>
        /// The local identity provider.
        /// </summary>
        public const string LocalIdP = OrgConstants.Oidc + ":idp:local";

        /// <summary>
        /// The back channel logout token.
        /// </summary>
        public const string LogoutToken = "logout_token";

        /// <summary>
        /// The OpenID Connect authentication protocol.
        /// </summary>
        public const string OpenIDConnect = "oidc";

        /// <summary>
        /// The default timeout for all <c>oidc</c> protocols.
        /// </summary>
        public const int DefaultTimeoutSeconds = 10;
    }
}
