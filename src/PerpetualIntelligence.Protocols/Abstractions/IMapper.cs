/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
