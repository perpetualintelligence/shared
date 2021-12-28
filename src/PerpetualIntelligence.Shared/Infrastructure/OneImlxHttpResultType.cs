/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
