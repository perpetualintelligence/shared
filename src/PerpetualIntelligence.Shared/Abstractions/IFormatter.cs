/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific formatter.
    /// </summary>
    /// <typeparam name="TContext">The checker context.</typeparam>
    /// <typeparam name="TResult">The checker result.</typeparam>
    public interface IFormatter<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Formats the context asynchronously.
        /// </summary>
        /// <param name="context">The formatter context.</param>
        /// <returns>The formatter result.</returns>
        Task<TResult> FormatAsync(TContext context);
    }
}
