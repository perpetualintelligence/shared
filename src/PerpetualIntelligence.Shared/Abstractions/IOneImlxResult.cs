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
    /// An abstraction of a generic <c>oneimlx</c> result.
    /// </summary>
    public interface IOneImlxResult
    {
        /// <summary>
        /// Determines if the result is an error.
        /// </summary>
        /// <value>A boolean value.</value>
        bool IsError { get; }
    }
}
