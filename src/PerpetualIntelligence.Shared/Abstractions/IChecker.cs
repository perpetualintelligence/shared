/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific checker.
    /// </summary>
    /// <typeparam name="TContext">The checker context.</typeparam>
    /// <typeparam name="TResult">The checker result.</typeparam>
    public interface IChecker<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Checks the context asynchronously.
        /// </summary>
        /// <param name="context">The checker context.</param>
        /// <returns>The checker result.</returns>
        Task<TResult> CheckAsync(TContext context);
    }
}
