/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
{
    /// <summary>
    /// The abstraction of a back-end store.
    /// </summary>
    /// <typeparam name="TSContext">The single entity context.</typeparam>
    /// <typeparam name="TMContext">The multiple entities context.</typeparam>
    /// <typeparam name="TSResult">The single entity result.</typeparam>
    /// <typeparam name="TMResult">The multiple entities result.</typeparam>
    /// <seealso cref="IEntity"/>
    /// <seealso cref="IStoreSingleResult{TEntity}"/>
    /// <seealso cref="IStoreMultipleResult{TEntity}"/>
    /// <seealso cref="ITrackedStore{TSContext, TMContext, TSResult, TMResult}"/>
    public interface IStore<TSContext, TMContext, TSResult, TMResult> where TSContext : class where TMContext : class where TSResult : class where TMResult : class
    {
        /// <summary>
        /// Creates an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The create context.</param>
        /// <returns>The create result.</returns>
        Task<TSResult> CreateAsync(TSContext context);

        /// <summary>
        /// Deletes an entity from the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The delete context.</param>
        /// <returns>The delete result.</returns>
        Task<TSResult> DeleteAsync(TSContext context);

        /// <summary>
        /// Finds an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The find context.</param>
        /// <returns>The find result.</returns>
        Task<TSResult> FindAsync(TSContext context);

        /// <summary>
        /// Lists the entities from the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The list context.</param>
        /// <returns>The list result.</returns>
        Task<TMResult> ListAsync(TMContext context);

        /// <summary>
        /// Locks an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The lock context.</param>
        /// <returns>The lock result.</returns>
        Task<TSResult> LockAsync(TSContext context);

        /// <summary>
        /// Creates or updates an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The put context.</param>
        /// <returns>The put result.</returns>
        Task<TSResult> PutAsync(TSContext context);

        /// <summary>
        /// Replaces an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The replace context.</param>
        /// <returns>The replace result.</returns>
        /// <remarks>Replace is a delete and create operation of the same entity.</remarks>
        Task<TSResult> ReplaceAsync(TSContext context);

        /// <summary>
        /// Unlocks an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The unlock context.</param>
        /// <returns>The unlock result.</returns>
        Task<TSResult> UnlockAsync(TSContext context);

        /// <summary>
        /// Updates an entity in the back-end store asynchronously.
        /// </summary>
        /// <param name="context">The update context.</param>
        /// <returns>The update result.</returns>
        Task<TSResult> UpdateAsync(TSContext context);
    }
}
