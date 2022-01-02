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
