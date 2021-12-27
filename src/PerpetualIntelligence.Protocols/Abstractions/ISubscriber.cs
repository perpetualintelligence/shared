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
    /// An abstraction of a context specific subscriber.
    /// </summary>
    /// <typeparam name="TContext">The subscriber context.</typeparam>
    /// <typeparam name="TResult">The subscriber result.</typeparam>
    public interface ISubscriber<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Subscribes asynchronously.
        /// </summary>
        /// <param name="context">The subscriber context.</param>
        /// <returns>The subscriber result.</returns>
        Task<TResult> SubscribeAsync(TContext context);
    }
}
