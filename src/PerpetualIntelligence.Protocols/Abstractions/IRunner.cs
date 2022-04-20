/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific runner.
    /// </summary>
    /// <typeparam name="TContext">The runner context.</typeparam>
    /// <typeparam name="TResult">The runner result.</typeparam>
    public interface IRunner<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Runs a context asynchronously.
        /// </summary>
        /// <param name="context">The runner context.</param>
        /// <returns>The runner result.</returns>
        Task<TResult> RunAsync(TContext context);
    }
}
