/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to return the subject's name.
    /// </summary>
    public interface INameAccessor
    {
        /// <summary>
        /// Returns the subject's name.
        /// </summary>
        /// <returns>The name.</returns>
        string? GetName();
    }
}
