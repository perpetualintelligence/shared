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
    /// An abstraction of context specific processor.
    /// </summary>
    /// <typeparam name="TContext">The processor context.</typeparam>
    public interface IPorcessor<TContext> where TContext : class
    {
        /// <summary>
        /// Processes asynchronously.
        /// </summary>
        /// <param name="context">The processor context.</param>
        Task ProcessAsync(TContext context);
    }
}
