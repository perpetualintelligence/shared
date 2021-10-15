/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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
