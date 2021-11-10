/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The <c>oneimlx</c> API constants.
    /// </summary>
    public static class ApiConstants
    {
        /// <summary>
        /// The imlx protocol identifier.
        /// </summary>
        public const string OneImlxId = "oneimlx";

        /// <summary>
        /// The named HTTP client for an API server.
        /// </summary>
        public const string ApiServerHttpClient = "urn:oneimlx:http:apiserver";

        /// <summary>
        /// The named HTTP client for the client application.
        /// </summary>
        public const string ClientAppHttpClient = "urn:oneimlx:http:clientapp";

        /// <summary>
        /// The API form content type <c>application/x-www-form-urlencoded</c>.
        /// </summary>
        public const string ContentTypeForm = "application/x-www-form-urlencoded";

        /// <summary>
        /// The API HTML content type <c>text/html; charset=UTF-8</c>.
        /// </summary>
        public const string ContentTypeHtml = "text/html; charset=UTF-8";

        /// <summary>
        /// The API JSON content type <c>application/json</c>.
        /// </summary>
        public const string ContentTypeJson = "application/json";

        /// <summary>
        /// The API Multipart content type <c>multipart/form-data</c>.
        /// </summary>
        public const string ContentTypeMultipart = "multipart/form-data";   

        /// <summary>
        /// The live mode of payments.
        /// </summary>
        public const string LivePayment = "urn:oneimlx:payment:live";

        /// <summary>
        /// The localhost endpoint.
        /// </summary>
        public const string LocalhostEndpoint = "urn:oneimlx:host:local";

        /// <summary>
        /// The production endpoint.
        /// </summary>
        public const string ProductionEndpoint = "urn:oneimlx:host:prod";

        /// <summary>
        /// The test mode of payments.
        /// </summary>
        public const string TestPayment = "urn:oneimlx:payment:test";
    }
}
