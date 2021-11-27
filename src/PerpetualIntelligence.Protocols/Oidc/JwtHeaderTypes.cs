/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The default valid types that will be used to check against the JWT header's 'typ' claim.
    /// </summary>
    [MustDo("Finalize the std format we cannot user urn format here. is this part of oauth spec ?")]
    public static class JwtHeaderTypes
    {
        /// <summary>
        /// OAuth 2.0 access token
        /// </summary>
        public const string AccessToken = "oneimlx-oidc-at+jwt";

        /// <summary>
        /// JWT secured authorization request.
        /// </summary>
        public const string AuthorizationRequest = "oneimlx-oidc-ar+jwt";
    }
}
