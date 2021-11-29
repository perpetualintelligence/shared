/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific response producer.
    /// </summary>
    public interface IProducer<TContext, TResponse> where TContext : class where TResponse : class
    {
        /// <summary>
        /// Produces the response asynchronously.
        /// </summary>
        /// <param name="context">The response context.</param>
        Task<TResponse> ProduceResponseAsync(TContext context);
    }
}
