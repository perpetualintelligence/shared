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
