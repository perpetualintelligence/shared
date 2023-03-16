/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific subscriber.
    /// </summary>
    /// <typeparam name="TContext">The subscriber context.</typeparam>
    /// <typeparam name="TResult">The subscriber result.</typeparam>
    public interface ISubscriber<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Subscribes asynchronously.
        /// </summary>
        /// <param name="context">The subscriber context.</param>
        /// <returns>The subscriber result.</returns>
        Task<TResult> SubscribeAsync(TContext context);
    }
}
