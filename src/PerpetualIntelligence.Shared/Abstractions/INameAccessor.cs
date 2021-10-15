/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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
        string? GetName();
    }
}
