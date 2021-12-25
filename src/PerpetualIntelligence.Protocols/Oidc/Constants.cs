/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.OneImlx;
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
        public const string AuthenticationType = Protocols.Constants.OneImlxOidc + ":auth";

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
        public const string CorsPolicyName = OrgConstants.OneImlxOrg + ".Cors";

        /// <summary>
        /// The default <c>check_session</c> cookie name.
        /// </summary>
        public const string DefaultCheckSessionCookieName = OrgConstants.OneImlxOrg + ".Cookie.Session";

        /// <summary>
        /// The default authentication cookie name.
        /// </summary>
        public const string DefaultCookieAuthenticationScheme = OrgConstants.OneImlxOrg + ".Cookie.Auth";

        /// <summary>
        /// The default external authentication cookie name.
        /// </summary>
        public const string DefaultExternalCookieAuthenticationScheme = OrgConstants.OneImlxOrg + ".Cookie.External";

        /// <summary>
        /// The <c>jwt</c> request key.
        /// </summary>
        public const string DefaultJwtRequestClientKey = Protocols.Constants.OneImlxOidc + ":scheme:jwt";

        /// <summary>
        /// The signout scheme.
        /// </summary>
        public const string DefaultSignoutScheme = Protocols.Constants.OneImlxOidc + ":scheme:signout";

        /// <summary>
        /// The local identity provider.
        /// </summary>
        public const string LocalIdP = Protocols.Constants.OneImlxOidc + ":idp:local";

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
