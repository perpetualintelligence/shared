/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Communication.Endpoints
{
    /// <summary>
    /// The abstraction of an endpoint request's response producer.
    /// </summary>
    public interface IEndpointRequestResponseProducer<TContext, TResponse> where TContext : class where TResponse : class
    {
        /// <summary>
        /// Produces the response asynchronously.
        /// </summary>
        /// <param name="context">The response context.</param>
        Task<TResponse> ProduceResponseAsync(TContext context);
    }
}
