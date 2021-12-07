/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific mapper.
    /// </summary>
    public interface IMapper<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Maps asynchronously.
        /// </summary>
        /// <param name="context">The producer context.</param>
        Task<TResult> MapAsync(TContext context);
    }
}
