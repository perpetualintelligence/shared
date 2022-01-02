/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
