﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
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
