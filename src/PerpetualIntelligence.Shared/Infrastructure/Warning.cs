/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> warning.
    /// </summary>
    public class Warning
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public Warning()
        {
            WarningCode = "unexpected_warning";
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="warning"></param>
        public Warning(string warning)
        {
            WarningCode = warning;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="warning"></param>
        /// <param name="warningDescription"></param>
        /// <param name="warningUri"></param>
        /// <param name="requestId"></param>
        /// <param name="httpStatusCode"></param>
        public Warning(string warning, string? warningDescription = null, string? warningUri = null, string? requestId = null, int? httpStatusCode = null)
        {
            WarningCode = warning;
            WarningDescription = warningDescription;
            WarningUri = warningUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The HTTP status code <c>http_status_code</c>.
        /// </summary>
        [JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request identifier for a request.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The <c>warning</c> code.
        /// </summary>
        [JsonPropertyName("warning")]
        public string WarningCode { get; set; }

        /// <summary>
        /// The <c>warning_description</c>.
        /// </summary>
        [JsonPropertyName("warning_description")]
        public string? WarningDescription { get; set; }

        /// <summary>
        /// The <c>warning_uri</c>.
        /// </summary>
        [JsonPropertyName("warning_uri")]
        public string? WarningUri { get; set; }
    }
}
