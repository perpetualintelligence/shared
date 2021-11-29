/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Communication.Events
{
    /// <summary>
    /// The abstraction to record an <see cref="IEvent"/> in the publish/subscribe-style communication without requiring
    /// the components to explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEvent"/>
    /// <seealso cref="IEventPublisher{TContext, TResult}"/>
    /// <seealso cref="IEventSubscriber{TContext, TResult}"/>
    public interface IEventRecorder<TContext, TResult> where TContext : class
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
