/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Communication.Events
{
    /// <summary>
    /// The abstraction to publish an <see cref="IEvent"/> in the publish/subscribe-style communication without
    /// requiring the components to explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEvent"/>
    /// <seealso cref="IEventSubscriber{TContext, TResult}"/>
    /// <seealso cref="IEventRecorder{TContext, TResult}"/>
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/multi-container-microservice-net-applications/integration-event-based-microservice-communications">
    /// Implementing event-based communication between micro-services (integration events)
    /// </seealso>
    public interface IEventPublisher<TContext, TResult> where TContext : class
    {
        /// <summary>
        /// Determines whether the <see cref="IEventPublisher{TContext, TResult}"/> can publish the specified event.
        /// </summary>
        /// <param name="context">The event context.</param>
        Task<bool> CanPublishAsync(TContext context);

        /// <summary>
        /// Publishes the specified event asynchronously.
        /// </summary>
        /// <param name="evt">The event context.</param>
        Task<TResult> PublishAsync(TContext evt);
    }
}
