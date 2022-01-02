/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

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
