/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
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
