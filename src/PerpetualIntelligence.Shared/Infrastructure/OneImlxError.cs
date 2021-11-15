/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> error.
    /// </summary>
    public class OneImlxError
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxError()
        {
            Error = "unexpected_error";
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="errorUri">The error URI.</param>
        /// <param name="requestId">The request id.</param>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        public OneImlxError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null, int? httpStatusCode = null)
        {
            Error = error;
            ErrorDescription = errorDescription;
            ErrorUri = errorUri;
            RequestId = requestId;
            HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// The <c>error</c> code.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// The <c>error_description</c>.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// The <c>error_uri</c>.
        /// </summary>
        [JsonPropertyName("error_uri")]
        public string? ErrorUri { get; set; }

        /// <summary>
        /// The HTTP status code <c>http_status_code</c>.
        /// </summary>
        [JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request identifier <c>request_id</c>.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }
    }
}
