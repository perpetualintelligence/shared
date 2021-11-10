// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com


namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The additional claim value types that are not defined in <see cref="System.Security.Claims.ClaimValueTypes"/>.
    /// </summary>
    public static class CustomClaimValueTypes
    {
        /// <summary>
        /// A URI that represents Json data type.
        /// </summary>
        public const string Json = "urn:oneimlx:oidc:claimvalue:json";
    }
}
