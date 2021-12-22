/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific publisher.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    /// <remarks>
    /// The <see cref="INoResultPublisher{TContext}"/> does not return any result during publish. See
    /// <see cref="IPublisher{TContext, TResult}"/> for publisher with result.
    /// </remarks>
    public interface INoResultPublisher<TContext> where TContext : class
    {
        /// <summary>
        /// Publishes asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task PublishAsync(TContext context);
    }
}
