/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="information"></param>
        /// <param name="informationDescription"></param>
        /// <param name="informationUri"></param>
        /// <param name="requestId"></param>
        public OneImlxInformation(string information, string? informationDescription = null, string? informationUri = null, string? requestId = null)
        {
            Information = information;
            InformationDescription = informationDescription;
            InformationUri = informationUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The <c>information</c> code. Defaults to <c>unexpected_information</c>.
        /// </summary>
        [JsonPropertyName("information")]
        public string Information { get; set; } = "unexpected_information";

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
