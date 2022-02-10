/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
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
