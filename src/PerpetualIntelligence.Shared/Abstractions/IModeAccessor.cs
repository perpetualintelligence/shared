/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to access the current mode.
    /// </summary>
    /// <seealso cref="Modes"/>
    public interface IModeAccessor
    {
        /// <summary>
        /// Returns the current mode.
        /// </summary>
        /// <returns>The current mode.</returns>
        /// <seealso cref="Modes.All"/>
        string GetMode();
    }
}
