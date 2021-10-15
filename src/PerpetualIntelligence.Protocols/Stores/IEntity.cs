/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System;
using System.Collections.Generic;

namespace PerpetualIntelligence.Protocols.Stores
{
    /// <summary>
    /// The abstraction of a store entity.
    /// </summary>
    /// <see cref="IStore{TSContext, TMContext, TSResult, TMResult}"/>
    /// <seealso cref="ITrackedStore{TSContext, TMContext, TSResult, TMResult}"/>
    public interface IEntity
    {
        /// <summary>
        /// The optimistic concurrency stamp during updates.
        /// </summary>
        string? ConcurrencyStamp { get;  }

        /// <summary>
        /// The create timestamp expressed in Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? CreateStamp { get; }

        /// <summary>
        /// Delete request timestamp of the entity expressed in the Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? DeleteStamp { get; }

        /// <summary>
        /// The entity name.
        /// </summary>
        string? Name { get; }

        /// <summary>
        /// The additional properties.
        /// </summary>
        Dictionary<string, string?>? Properties { get; }

        /// <summary>
        /// The tags.
        /// </summary>
        string[]? Tags { get; }

        /// <summary>
        /// The update timestamp expressed in Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? UpdateStamp { get; }

        /// <summary>
        /// Returns the store entity identity.
        /// </summary>
        /// <returns></returns>
        Identity GetIdentity();
    }
}
