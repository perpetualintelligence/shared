/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
