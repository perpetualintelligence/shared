/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions.Events
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
