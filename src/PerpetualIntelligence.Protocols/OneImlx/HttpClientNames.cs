/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/


namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The HTTP client names used by the <c>oneimlx</c> managed services.
    /// </summary>
    public static class HttpClientNames
    {
        /// <summary>
        /// The client application HTTP client name.
        /// </summary>
        public const string ClientApp = "urn:oneimlx:http:capp";

        /// <summary>
        /// The API server HTTP client name.
        /// </summary>
        public const string ApiServer = "urn:oneimlx:http:apisvr";

        /// <summary>
        /// The <c>jwt_uris</c> HTTP client name.
        /// </summary>
        public const string JwtRequestUri = "urn:oneimlx:http:jwturis";

        /// <summary>
        /// The back channel logout HTTP client name.
        /// </summary>
        public const string BackChannelLogout = "urn:oneimlx:http:bclogout";
    }
}
