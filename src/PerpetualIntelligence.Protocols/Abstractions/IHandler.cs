/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific request handler.
    /// </summary>
    /// <typeparam name="TContext">The endpoint handler context.</typeparam>
    /// <typeparam name="TResult">The endpoint handler result.</typeparam>
    public interface IHandler<TContext, TResult> where TContext : class where TResult : class, IPublisher<TContext>
    {
        /// <summary>
        /// Handles the request.
        /// </summary>
        /// <param name="context">The request handler context.</param>
        /// <returns>The request handler instance.</returns>
        Task<TResult> HandleRequestAsync(TContext context);
    }
}
