/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The HTTP result type during <c>oidc</c> protocol execution.
    /// </summary>
    public enum OneImlxHttpResultType
    {
        /// <summary>
        /// Indicates the HTTP response is available to process.
        /// </summary>
        HttpResponse,

        /// <summary>
        /// Indicates an exception connecting the endpoint or an API. No HTTP response is available to process.
        /// </summary>
        Exception,
    }
}
