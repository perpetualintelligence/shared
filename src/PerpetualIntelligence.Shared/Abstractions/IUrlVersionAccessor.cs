/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a URL version accessor.
    /// </summary>
    public interface IUrlVersionAccessor
    {
        /// <summary>
        /// Gets the URL version.
        /// </summary>
        string GetVersion();
    }
}
