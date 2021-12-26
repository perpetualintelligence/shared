/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
