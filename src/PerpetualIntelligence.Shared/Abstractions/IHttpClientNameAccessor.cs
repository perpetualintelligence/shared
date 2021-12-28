/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Net.Http;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of the <see cref="HttpClient"/> name accessor.
    /// </summary>
    public interface IHttpClientNameAccessor
    {
        /// <summary>
        /// The HTTP client name.
        /// </summary>
        /// <value>The HTTP client name.</value>
        string Name { get; }
    }
}
