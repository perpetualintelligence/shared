/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
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
        public string? Type { get; set; }

        /// <summary>
        /// The assertion value.
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// The client identifier <c>client_id</c>.
        /// </summary>
        public string? ClientId { get; set; }
    }
}
