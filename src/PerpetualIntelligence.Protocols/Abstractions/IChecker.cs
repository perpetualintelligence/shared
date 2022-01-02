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
    /// An abstraction of a context specific checker.
    /// </summary>
    /// <typeparam name="TContext">The checker context.</typeparam>
    /// <typeparam name="TResult">The checker result.</typeparam>
    public interface IChecker<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Checks the context asynchronously.
        /// </summary>
        /// <param name="context">The checker context.</param>
        /// <returns>The checker result.</returns>
        Task<TResult> CheckAsync(TContext context);
    }
}
