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
    /// The abstraction to record an <see cref="IEvent"/> in the publish/subscribe-style communication without requiring
    /// the components to explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEvent"/>
    /// <seealso cref="IEventPublisher{TContext, TResult}"/>
    /// <seealso cref="IEventSubscriber{TContext, TResult}"/>
    public interface IEventRecorder<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Determines whether the <see cref="IEventRecorder{TContext, TResult}"/> can record the specified event.
        /// </summary>
        /// <param name="context">The event context.</param>
        Task<bool> CanRecordAsync(TContext context);

        /// <summary>
        /// Records the specified event asynchronously.
        /// </summary>
        /// <param name="context">The event context to record.</param>
        Task<TResult> RecordAsync<TEvent>(TContext context);
    }
}
