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
    /// Represents a base warning model for all <c>oneimlx</c> services.
    /// </summary>
    public class OneImlxWarning
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxWarning()
        {
            Warning = Errors.UnexpectedWarning;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="warning"></param>
        public OneImlxWarning(string warning)
        {
            Warning = warning;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="warning"></param>
        /// <param name="warningDescription"></param>
        /// <param name="warningUri"></param>
        /// <param name="requestId"></param>
        public OneImlxWarning(string warning, string? warningDescription = null, string? warningUri = null, string? requestId = null)
        {
            Warning = warning;
            WarningDescription = warningDescription;
            WarningUri = warningUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The request identifier for a request.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The <c>warning</c> code.
        /// </summary>
        [JsonPropertyName("warning")]
        public string Warning { get; set; }

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
