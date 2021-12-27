/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of context specific publisher.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    /// <typeparam name="TResult">The publisher context.</typeparam>
    public interface IPublisher<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Publishes asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task<TResult> ProcessAsync(TContext context);
    }
}
