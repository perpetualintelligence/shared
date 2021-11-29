/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        /// <param name="context">The run context.</param>
        /// <returns>The run result.</returns>
        Task<TResult> RunAsync(TContext context);
    }
}
