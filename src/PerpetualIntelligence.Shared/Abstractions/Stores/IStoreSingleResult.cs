/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions.Stores
{
    /// <summary>
    /// The abstraction of a store result that yields a single entity.
    /// </summary>
    /// <seealso cref="IStoreMultipleResult{TEntity}"/>
    public interface IStoreSingleResult<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// The single entity.
        /// </summary>
        TEntity? Result { get; }
    }
}
