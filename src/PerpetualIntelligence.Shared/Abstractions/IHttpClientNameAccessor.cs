/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
