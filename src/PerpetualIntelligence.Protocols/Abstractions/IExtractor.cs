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
    /// An abstraction of a context specific extractor.
    /// </summary>
    /// <typeparam name="TContext">The extractor context.</typeparam>
    /// <typeparam name="TResult">The extractor result.</typeparam>
    public interface IExtractor<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Extracts from a context asynchronously.
        /// </summary>
        /// <param name="context">The extractor context.</param>
        /// <returns>The extractor result.</returns>
        Task<TResult> ExtractAsync(TContext context);
    }
}
