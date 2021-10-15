/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Communication.Endpoints
{
    /// <summary>
    /// The abstraction of an endpoint request handler.
    /// </summary>
    /// <typeparam name="TContext">The endpoint handler context.</typeparam>
    /// <typeparam name="TResult">The endpoint handler result.</typeparam>
    public interface IEndpointRequestHandler<TContext, TResult> where TContext : class where TResult : class, IEndpointRequestResult<TContext>
    {
        /// <summary>
        /// Handles the request.
        /// </summary>
        /// <param name="context">The request handler context.</param>
        /// <returns>The request handler instance.</returns>
        Task<TResult?> HandleRequestAsync(TContext context);
    }
}
