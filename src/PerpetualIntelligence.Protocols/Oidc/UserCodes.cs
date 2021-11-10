/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Defines the user code types in the device flow authentication.
    /// </summary>
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
