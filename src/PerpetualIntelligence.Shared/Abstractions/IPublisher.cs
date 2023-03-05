/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of context specific publisher.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    /// <typeparam name="TResult">The publisher context.</typeparam>
    public interface IPublisher<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Publishes asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task<TResult> ProcessAsync(TContext context);
    }
}
