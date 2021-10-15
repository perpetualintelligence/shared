/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Stores
{
    /// <summary>
    /// The abstraction of a store result that yields multiple entities.
    /// </summary>
    /// <see cref="IStoreSingleResult{TEntity}"/>
    public interface IStoreMultipleResult<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// The continuation token to get the next set of entities.
        /// </summary>
        public string? ContinuationToken { get; }

        /// <summary>
        /// The store entities.
        /// </summary>
        TEntity[]? Result { get; }
    }
}
