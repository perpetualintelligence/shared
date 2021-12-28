/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Abstractions.Events
{
    /// <summary>
    /// The abstraction of an event in the publish/subscribe-style communication without requiring the components to
    /// explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEventSubscriber{TContext, TResult}"/>
    /// <seealso cref="IEventPublisher{TContext, TResult}"/>
    /// <seealso cref="IEventRecorder{TContext, TResult}"/>
    public interface IEvent
    {
        /// <summary>
        /// The unique event name.
        /// </summary>
        public string Name { get; }
    }
}
