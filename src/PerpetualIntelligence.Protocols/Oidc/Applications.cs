/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect application types.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-registration-1_0.html"/>
    public static class Applications
    {
        /// <summary>
        /// The native application such as a JAVAScript application, Blazor WebAssembly or a mobile application.
        /// </summary>
        public const string Native = "native";

        /// <summary>
        /// The Web application.
        /// </summary>
        public const string Web = "web";
    }
}
