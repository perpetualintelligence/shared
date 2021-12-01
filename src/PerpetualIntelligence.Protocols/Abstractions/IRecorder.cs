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
    /// An abstraction of a context specific recorder.
    /// </summary>
    /// <typeparam name="TContext">The recorder context.</typeparam>
    /// <typeparam name="TResult">The recorder result.</typeparam>
    public interface IRecorder<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Records asynchronously.
        /// </summary>
        /// <param name="context">The recorder context.</param>
        /// <returns>The recorder result.</returns>
        Task<TResult> RecordAsync<TEvent>(TContext context);
    }
}
