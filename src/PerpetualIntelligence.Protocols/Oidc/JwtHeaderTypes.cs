/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The default valid types that will be used to check against the JWT header's 'typ' claim.
    /// </summary>
    public static class JwtHeaderTypes
    {
        /// <summary>
        /// OAuth 2.0 access token
        /// </summary>
        public const string AccessToken = "urn:pi:protocols:oidc:jwttyp:at";

        /// <summary>
        /// JWT secured authorization request.
        /// </summary>
        public const string AuthorizationRequest = "urn:pi:protocols:oidc:jwttyp:ar";
    }
}
