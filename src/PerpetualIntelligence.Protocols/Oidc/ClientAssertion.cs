/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The client assertion in an OAuth or OpenID Connect authorization flow.
    /// </summary>    
    public class ClientAssertion
    {
        /// <summary>
        /// The assertion type.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The assertion value.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The client identifier <c>client_id</c>.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string? ClientId { get; set; }
    }
}
