/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        string Name { get; }
    }
}
