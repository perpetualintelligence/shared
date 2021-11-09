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
    /// Represents a base information model for all <c>oneimlx</c> services.
    /// </summary>
    public class OneImlxInformation
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxInformation()
        {
            Information = Errors.UnexpectedInformation;
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
        public OneImlxInformation(string information, string? informationDescription = null, string? informationUri = null, string? requestId = null)
        {
            Information = information;
            InformationDescription = informationDescription;
            InformationUri = informationUri;
            RequestId = requestId;
        }

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
