/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
        public const string Otp = "urn:oneimlx:oidc:login:otp";

        /// <summary>
        /// The user password.
        /// </summary>
        public const string Password = "urn:oneimlx:oidc:login:pwd";

        /// <summary>
        /// The personal identification number or a pattern.
        /// </summary>
        public const string Pin = "urn:oneimlx:oidc:login:pin";

        /// <summary>
        /// The unknown.
        /// </summary>
        public const string Unknown = "urn:oneimlx:oidc:login:unknown";
    }
}
