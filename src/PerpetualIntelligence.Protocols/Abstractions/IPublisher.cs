/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific publisher.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    public interface IPublisher<TContext> where TContext : class
    {
        /// <summary>
        /// Publishes the response asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task PublishAsync(TContext context);
    }
}
