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
    /// An abstraction of a context specific handler.
    /// </summary>
    /// <typeparam name="TContext">The handler context.</typeparam>
    /// <typeparam name="TResult">The handler result.</typeparam>
    public interface IHandler<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Handles the context.
        /// </summary>
        /// <param name="context">The handler context.</param>
        /// <returns>The handler result.</returns>
        Task<TResult> HandleAsync(TContext context);
    }
}
