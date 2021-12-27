/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Security.Claims;

namespace PerpetualIntelligence.Protocols.Security
{
    /// <summary>
    /// Defines authentication constants.
    /// </summary>
    public static class Authentication
    {
        /// <summary>
        /// The bearer token in authorization header.
        /// </summary>
        public const string BearerAuthorizationHeader = "Bearer";

        /// <summary>
        /// The bearer token type.
        /// </summary>
        public const string BearerTokenType = "Bearer";

        /// <summary>
        /// The authentication type used to create the <see cref="ClaimsPrincipal"/>.
        /// </summary>
        public const string DefaultAuthenticationType = Protocols.Constants.OneImlxOpenIDConnectUrn + ":auth";

        /// <summary>
        /// The default <c>check_session</c> cookie name.
        /// </summary>
        public const string DefaultCheckSessionCookieName = Protocols.Constants.OneImlxOrg + ".Cookie.Session";

        /// <summary>
        /// The default authentication cookie name.
        /// </summary>
        public const string DefaultCookieAuthenticationScheme = Protocols.Constants.OneImlxOrg + ".Cookie.Auth";

        /// <summary>
        /// The default CORS policy name.
        /// </summary>
        public const string DefaultCorsPolicyName = Protocols.Constants.OneImlxOrg + ".Trustcenter.Cors";

        /// <summary>
        /// The default external authentication cookie name.
        /// </summary>
        public const string DefaultExternalCookieAuthenticationScheme = Protocols.Constants.OneImlxOrg + ".Cookie.External";

        /// <summary>
        /// The <c>jwt</c> request key scheme.
        /// </summary>
        public const string DefaultJwtRequestClientKeyScheme = Protocols.Constants.OneImlxUrn + ":scheme:jwt";

        /// <summary>
        /// The local identity provider.
        /// </summary>
        public const string DefaultLocalIdP = Protocols.Constants.OneImlxUrn + ":scheme:lidp";

        /// <summary>
        /// The signout scheme.
        /// </summary>
        public const string DefaultSignoutScheme = Protocols.Constants.OneImlxUrn + ":scheme:signout";

        /// <summary>
        /// The default timeout for all <c>oidc</c> protocols.
        /// </summary>
        public const int DefaultTimeoutSeconds = 10;
    }
}
