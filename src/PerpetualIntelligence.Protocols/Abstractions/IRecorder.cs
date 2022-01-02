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
    /// An abstraction of a context specific recorder.
    /// </summary>
    /// <typeparam name="TContext">The recorder context.</typeparam>
    /// <typeparam name="TResult">The recorder result.</typeparam>
    public interface IRecorder<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Records asynchronously.
        /// </summary>
        /// <param name="context">The recorder context.</param>
        /// <returns>The recorder result.</returns>
        Task<TResult> RecordAsync<TEvent>(TContext context);
    }
}
