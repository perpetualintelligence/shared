/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The HTTP result type during <c>oidc</c> protocol execution.
    /// </summary>
    public enum OneImlxHttpResultType
    {
        /// <summary>
        /// Indicates the HTTP response is available to process an error or a success.
        /// </summary>
        HttpResponse,

        /// <summary>
        /// Indicates an exception connecting to the endpoint. No HTTP response is available to process.
        /// </summary>
        Exception,
    }
}
