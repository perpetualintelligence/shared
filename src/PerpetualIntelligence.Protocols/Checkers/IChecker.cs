﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Checkers
{
    /// <summary>
    /// An abstraction of a context specific checker.
    /// </summary>
    /// <typeparam name="TContext">The checker context.</typeparam>
    /// <typeparam name="TResult">The checker result.</typeparam>
    [Concept("Checkers")]
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