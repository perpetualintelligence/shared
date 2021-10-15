/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The <c>imlx</c> API constants.
    /// </summary>
    public static class ApiConstants
    {
        /// <summary>
        /// The imlx protocol identifier.
        /// </summary>
        public const string ImlxId = "imlx";

        /// <summary>
        /// The named HTTP client for an API server.
        /// </summary>
        public const string ApiServerHttpClient = "urn:pi:protocols:imlx:http:server";

        /// <summary>
        /// The named HTTP client for the client application.
        /// </summary>
        public const string ClientAppHttpClient = "urn:pi:protocols:imlx:http:client";

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
        public const string LivePayment = "urn:pi:protocols:imlx:payment:live";

        /// <summary>
        /// The localhost endpoint.
        /// </summary>
        public const string LocalhostEndpoint = "urn:pi:protocols:imlx:host:local";

        /// <summary>
        /// The production endpoint.
        /// </summary>
        public const string ProductionEndpoint = "urn:pi:protocols:imlx:host:prod";

        /// <summary>
        /// The test mode of payments.
        /// </summary>
        public const string TestPayment = "urn:pi:protocols:imlx:payment:test";
    }
}
