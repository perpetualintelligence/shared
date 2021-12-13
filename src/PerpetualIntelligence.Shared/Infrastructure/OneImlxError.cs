/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> error response.
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
        public OneImlxError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

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
        /// The <c>error_description</c>.
        /// </summary>
        [JsonPropertyName("error_description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// The <c>error_uri</c>.
        /// </summary>
        [JsonPropertyName("error_uri")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ErrorUri { get; set; }

        /// <summary>
        /// The request identifier <c>request_id</c>.
        /// </summary>
        [JsonPropertyName("request_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequestId { get; set; }

        /// <summary>
        /// Set an error.
        /// </summary>
        public void SetError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            Error = error;
            ErrorDescription = errorDescription;
            ErrorUri = errorUri;
            RequestId = requestId;
        }
    }
}
