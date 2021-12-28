/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific runner.
    /// </summary>
    /// <typeparam name="TContext">The runner context.</typeparam>
    /// <typeparam name="TResult">The runner result.</typeparam>
    public interface IRunner<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Runs a context asynchronously.
        /// </summary>
        /// <param name="context">The runner context.</param>
        /// <returns>The runner result.</returns>
        Task<TResult> RunAsync(TContext context);
    }
}
