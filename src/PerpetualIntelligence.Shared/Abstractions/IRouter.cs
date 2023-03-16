﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific router.
    /// </summary>
    /// <typeparamref name="TContext">The router context.</typeparamref>
    /// <typeparamref name="TResult">The router result.</typeparamref>
    /// <typeparamref name="THandler">The route handler.</typeparamref>
    public interface IRouter<TContext, TResult, THandler> where TContext : class where TResult : class where THandler : class
    {
        /// <summary>
        /// Routes the request asynchronously.
        /// </summary>
        /// <param name="context">The router context.</param>
        /// <returns>The router result.</returns>
        Task<TResult> RouteAsync(TContext context);

        /// <summary>
        /// Finds a matching route handler for a request asynchronously.
        /// </summary>
        /// <param name="context">The router context.</param>
        /// <returns>The request handler.</returns>
        Task<TryResultOrError<THandler>> TryFindHandlerAsync(TContext context);
    }
}
