/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to generate a component identifier.
    /// </summary>
    public interface IComponentIdGenerator
    {
        /// <summary>
        /// Generates a new component id.
        /// </summary>
        /// <returns>A new component id.</returns>
        string NewId();
    }
}
