/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The HTTP result type during <c>oidc</c> protocol execution.
    /// </summary>
    public enum HttpResultType
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
