/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The client assertion in an OAuth or OpenID Connect authorization flow.
    /// </summary>
    public class ClientAssertion
    {
        /// <summary>
        /// The client identifier <c>client_id</c>.
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// The assertion type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// The assertion value.
        /// </summary>
        public string? Value { get; set; }
    }
}
