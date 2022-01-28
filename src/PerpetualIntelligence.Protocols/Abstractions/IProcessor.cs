/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of context specific processor.
    /// </summary>
    /// <typeparam name="TContext">The processor context.</typeparam>
    public interface IProcessor<TContext> where TContext : class
    {
        /// <summary>
        /// Processes asynchronously.
        /// </summary>
        /// <param name="context">The processor context.</param>
        Task ProcessAsync(TContext context);
    }
}
