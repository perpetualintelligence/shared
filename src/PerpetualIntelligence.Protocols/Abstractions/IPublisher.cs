/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific response publisher.
    /// </summary>
    /// <typeparam name="TContext">The endpoint request context.</typeparam>
    public interface IPublisher<TContext> where TContext : class
    {
        /// <summary>
        /// Determines whether the result publishes a response to the requesting party (RP).
        /// </summary>
        /// <value><c>true</c> if the request produces a response, otherwise <c>false</c>.</value>
        bool PublishesResponse { get; }

        /// <summary>
        /// Processes the result and publishes the response (if supported) as an asynchronous operation.
        /// </summary>
        /// <param name="context">The context.</param>
        Task ProcessResultAsync(TContext context);
    }
}
