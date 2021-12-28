/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
{
    /// <summary>
    /// The abstraction of a back-end store that supports tracked operation.
    /// </summary>
    /// <typeparam name="TSContext">The single entity context.</typeparam>
    /// <typeparam name="TMContext">The multiple entity context.</typeparam>
    /// <typeparam name="TSResult">The single entity result.</typeparam>
    /// <typeparam name="TMResult">The multiple entities result.</typeparam>
    /// <seealso cref="IStore{TSContext, TMContext, TSResult, TMResult}"/>
    public interface ITrackedStore<TSContext, TMContext, TSResult, TMResult> : IStore<TSContext, TMContext, TSResult, TMResult> where TSContext : class where TMContext : class where TSResult : class where TMResult : class
    {
        /// <summary>
        /// Removes or clears the entity deletion in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The clear delete context.</param>
        /// <returns>The clear delete result.</returns>
        Task<TSResult> ClearDeleteAsync(TSContext context);

        /// <summary>
        /// Marks an entity for deletion in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The mark delete context.</param>
        /// <returns>The mark delete result.</returns>
        Task<TSResult> MarkDeleteAsync(TSContext context);
    }
}
