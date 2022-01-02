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
    /// Defines the user code types in the device flow authentication.
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
    public static class UserCodes
    {
        /// <summary>
        /// Alphanumeric code.
        /// </summary>
        public const string AlphaNumeric = "urn:oneimlx:oidc:ucode:anum";

        /// <summary>
        /// Numeric code.
        /// </summary>
        public const string Numeric = "urn:oneimlx:oidc:ucode:num";
    }
}
