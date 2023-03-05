/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific handler with no result.
    /// </summary>
    /// <typeparam name="TContext">The handler context.</typeparam>
    public interface IHandlerNoResult<TContext> where TContext : class
    {
        /// <summary>
        /// Handles the context.
        /// </summary>
        /// <param name="context">The handler context.</param>
        /// <returns>The handler result.</returns>
        Task HandleAsync(TContext context);
    }
}
