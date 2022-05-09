/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of context specific no result processor.
    /// </summary>
    /// <typeparam name="TContext">The processor context.</typeparam>
    /// <seealso cref="IProcessor{TContext, TResult}"/>
    public interface IProcessorNoResult<TContext> where TContext : class
    {
        /// <summary>
        /// Processes asynchronously.
        /// </summary>
        /// <param name="context">The processor context.</param>
        Task ProcessAsync(TContext context);
    }
}
