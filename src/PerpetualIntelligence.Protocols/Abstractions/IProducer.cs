/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Abstractions;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific result producer.
    /// </summary>
    public interface IProducer<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Produces the result asynchronously.
        /// </summary>
        /// <param name="context">The producer context.</param>
        Task<TResult> ProduceResponseAsync(TContext context);
    }
}
