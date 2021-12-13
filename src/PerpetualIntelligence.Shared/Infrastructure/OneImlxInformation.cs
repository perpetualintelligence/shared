/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> information.
    /// </summary>
    public class OneImlxInformation
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxInformation()
        {
            Information = "unexpected_information";
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="information"></param>
        public OneImlxInformation(string information)
        {
            Information = information;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="information"></param>
        /// <param name="informationDescription"></param>
        /// <param name="informationUri"></param>
        /// <param name="requestId"></param>
        /// <param name="httpStatusCode"></param>
        public OneImlxInformation(string information, string? informationDescription = null, string? informationUri = null, string? requestId = null, int? httpStatusCode = null)
        {
            Information = information;
            InformationDescription = informationDescription;
            InformationUri = informationUri;
            RequestId = requestId;
            HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// The HTTP status code <c>http_status_code</c>.
        /// </summary>
        [JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The <c>information</c> code.
        /// </summary>
        [JsonPropertyName("information")]
        public string Information { get; set; }

        /// <summary>
        /// The <c>information_description</c>.
        /// </summary>
        [JsonPropertyName("information_description")]
        public string? InformationDescription { get; set; }

        /// <summary>
        /// The <c>information_uri</c>.
        /// </summary>
        [JsonPropertyName("information_uri")]
        public string? InformationUri { get; set; }

        /// <summary>
        /// The request identifier for a request.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }
    }
}
