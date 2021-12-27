/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The HTTP client names used by the <c>oneimlx</c> managed services.
    /// </summary>
    public static class HttpClientNames
    {
        /// <summary>
        /// The API server HTTP client name.
        /// </summary>
        public const string ApiServer = "urn:oneimlx:http:apisvr";

        /// <summary>
        /// The back channel logout HTTP client name.
        /// </summary>
        public const string BackChannelLogout = "urn:oneimlx:http:bclogout";

        /// <summary>
        /// The client application HTTP client name.
        /// </summary>
        public const string ClientApp = "urn:oneimlx:http:capp";

        /// <summary>
        /// The <c>jwt_uris</c> HTTP client name.
        /// </summary>
        public const string JwtRequestUri = "urn:oneimlx:http:jwturis";
    }
}
