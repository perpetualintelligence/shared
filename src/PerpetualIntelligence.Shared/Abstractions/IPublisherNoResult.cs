/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific publisher with no explicit result.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    /// <remarks>
    /// The <see cref="IPublisherNoResult{TContext}"/> does not return any result during publish. See
    /// <see cref="IPublisher{TContext, TResult}"/> for publisher with result.
    /// </remarks>
    public interface IPublisherNoResult<TContext> where TContext : class
    {
        /// <summary>
        /// Publishes asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task PublishAsync(TContext context);
    }
}
