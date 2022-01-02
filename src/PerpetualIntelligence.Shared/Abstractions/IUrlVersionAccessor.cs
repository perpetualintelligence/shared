/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
