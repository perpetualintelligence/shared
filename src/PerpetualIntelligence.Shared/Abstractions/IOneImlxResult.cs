/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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
