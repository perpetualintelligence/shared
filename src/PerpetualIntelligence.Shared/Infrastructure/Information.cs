/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> information.
    /// </summary>
    public class Information
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public Information()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="information"></param>
        /// <param name="informationDescription"></param>
        /// <param name="informationUri"></param>
        /// <param name="requestId"></param>
        public Information(string information, string? informationDescription = null, string? informationUri = null, string? requestId = null)
        {
            InformationCode = information;
            InformationDescription = informationDescription;
            InformationUri = informationUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The <c>information</c> code. Defaults to <c>unexpected_information</c>.
        /// </summary>
        [JsonPropertyName("information")]
        public string InformationCode { get; set; } = "unexpected_information";

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
