/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Oidc;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// Represents a base error model for all <c>oneimlx</c> services.
    /// </summary>
    public class OneImlxError
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxError()
        {
            Error = Errors.UnexpectedError;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="errorUri"></param>
        /// <param name="requestId"></param>
        public OneImlxError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null)
        {
            Error = error;
            ErrorDescription = errorDescription;
            ErrorUri = errorUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The <c>error</c> code.
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// The <c>error_uri</c>.
        /// </summary>
        [JsonPropertyName("error_uri")]
        public string? ErrorUri { get; set; }

        /// <summary>
        /// The <c>error_description</c>.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// The request identifier for a request.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }
    }
}
