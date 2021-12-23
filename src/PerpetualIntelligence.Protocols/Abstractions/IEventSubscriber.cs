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
    /// The abstraction to subscribe an <see cref="IEvent"/> in the publish/subscribe-style communication without
    /// requiring the components to explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEvent"/>
    /// <seealso cref="IEventPublisher{TContext, TResult}"/>
    /// <seealso cref="IEventRecorder{TContext, TResult}"/>
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/multi-container-microservice-net-applications/integration-event-based-microservice-communications">
    /// Implementing event-based communication between micro-services (integration events)
    /// </seealso>
    public interface IEventSubscriber<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Determines whether the <see cref="IEventSubscriber{TContext, TResult}"/> can subscribe the specified event.
        /// </summary>
        /// <param name="context">The event context</param>
        Task<bool> CanSubscribeAsync(TContext context);

        /// <summary>
        /// Subscribes the specified event asynchronously.
        /// </summary>
        /// <param name="context">The event context subscribe.</param>
        Task<TResult> SubscribeAsync(TContext context);
    }
}
