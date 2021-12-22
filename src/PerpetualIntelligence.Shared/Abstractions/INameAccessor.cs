/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
