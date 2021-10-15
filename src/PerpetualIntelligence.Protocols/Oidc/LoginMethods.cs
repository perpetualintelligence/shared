/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Defines the methods for OpenID Connect authentication.
    /// </summary>
    public static class LoginMethods
    {
        /// <summary>
        /// The one-time pass-code.
        /// </summary>
        public const string Otp = "urn:pi:protocols:oidc:login:otp";

        /// <summary>
        /// The user password.
        /// </summary>
        public const string Password = "urn:pi:protocols:oidc:login:pwd";

        /// <summary>
        /// The personal identification number or a pattern.
        /// </summary>
        public const string Pin = "urn:pi:protocols:oidc:login:pin";

        /// <summary>
        /// The unknown.
        /// </summary>
        public const string Unknown = "urn:pi:protocols:oidc:login:unknown";
    }
}
