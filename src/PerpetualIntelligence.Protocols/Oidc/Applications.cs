/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect application types.
    /// </summary>
    public static class Applications
    {
        /// <summary>
        /// The native application such as a JAVAScript application or a Blazor WebAssembly.
        /// </summary>
        public const string Native = "native";

        /// <summary>
        /// The mobile application.
        /// </summary>
        public const string Mobile = "mobile";

        /// <summary>
        /// The Web application.
        /// </summary>
        public const string Web = "web";
    }
}
