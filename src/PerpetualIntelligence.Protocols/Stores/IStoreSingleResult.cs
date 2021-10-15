/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Stores
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
