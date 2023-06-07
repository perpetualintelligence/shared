/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
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
        Task<TResult> ProduceAsync(TContext context);
    }
}
