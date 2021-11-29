/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Abstractions;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific request router.
    /// </summary>
    /// <typeparamref name="TContext">The endpoint request handler context.</typeparamref>
    /// <typeparamref name="TResult">The endpoint request handler result.</typeparamref>
    /// <typeparamref name="THandler">The endpoint request handler.</typeparamref>
    public interface IRouter<TContext, TResult, THandler> where TContext : class where TResult : class, IPublisher<TContext> where THandler : class, IHandler<TContext, TResult>
    {
        /// <summary>
        /// Finds a matching <see cref="IHandler{TContext, TResult}"/> based on the current request asynchronously.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The <see cref="IHandler{TContext, TResult}"/> if found, otherwise <c>null</c>.</returns>
        Task<THandler?> FindHandlerAsync(TContext context);

        /// <summary>
        /// Routes the request to the appropriate <see cref="IHandler{TContext, TResult}"/> asynchronously.
        /// </summary>
        /// <param name="context">The endpoint request context.</param>
        Task<bool> RouteRequestAsync(TContext context);
    }
}
