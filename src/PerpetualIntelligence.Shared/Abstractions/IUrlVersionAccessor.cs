// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

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
