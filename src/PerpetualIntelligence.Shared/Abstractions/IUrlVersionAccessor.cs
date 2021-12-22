/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
        /// <returns>The version string.</returns>
        string GetVersion();
    }
}
