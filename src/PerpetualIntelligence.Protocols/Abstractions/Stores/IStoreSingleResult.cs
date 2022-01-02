/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
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
