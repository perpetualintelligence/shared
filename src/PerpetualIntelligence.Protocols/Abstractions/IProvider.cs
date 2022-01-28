/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of context specific provider.
    /// </summary>
    /// <typeparam name="TContext">The provider context.</typeparam>
    /// <typeparam name="TResult">The provider result.</typeparam>
    public interface IProvider<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Provides asynchronously.
        /// </summary>
        /// <param name="context">The provider context.</param>
        Task<TResult> ProvideAsync(TContext context);
    }
}
