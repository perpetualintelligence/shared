/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Communication.Endpoints
{
    /// <summary>
    /// The abstraction that routes the incoming request to an appropriate <see cref="IEndpointRequestHandler{TContext, TResult}"/>.
    /// </summary>
    /// <typeparamref name="TContext">The endpoint request handler context.</typeparamref>
    /// <typeparamref name="TResult">The endpoint request handler result.</typeparamref>
    /// <typeparamref name="THandler">The endpoint request handler.</typeparamref>
    public interface IEndpointRequestRouter<TContext, TResult, THandler> where TContext : class where TResult : class, IEndpointRequestResult<TContext> where THandler : class, IEndpointRequestHandler<TContext, TResult>
    {
        /// <summary>
        /// Finds a matching <see cref="IEndpointRequestHandler{TContext, TResult}"/> based on the current request asynchronously.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The <see cref="IEndpointRequestHandler{TContext, TResult}"/> if found, otherwise <c>null</c>.</returns>
        Task<THandler?> FindHandlerAsync(TContext context);

        /// <summary>
        /// Routes the request to the appropriate <see cref="IEndpointRequestHandler{TContext, TResult}"/> asynchronously.
        /// </summary>
        /// <param name="context">The endpoint request context.</param>
        Task<bool> RouteRequestAsync(TContext context);
    }
}
