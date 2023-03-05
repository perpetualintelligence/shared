/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of context specific processor.
    /// </summary>
    /// <typeparam name="TContext">The processor context.</typeparam>
    /// <typeparam name="TResult">The processor result.</typeparam>
    /// <seealso cref="IProcessorNoResult{TContext}"/>
    public interface IProcessor<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Processes asynchronously.
        /// </summary>
        /// <param name="context">The processor context.</param>
        Task<TResult> ProcessAsync(TContext context);
    }
}
