/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Collections.Generic;

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
{
    /// <summary>
    /// The abstraction of a persisted entity.
    /// </summary>
    /// <see cref="IStore{TSContext, TMContext, TSResult, TMResult}"/>
    /// <seealso cref="ITrackedStore{TSContext, TMContext, TSResult, TMResult}"/>
    public interface IEntity
    {
        /// <summary>
        /// The optimistic concurrency stamp during updates.
        /// </summary>
        string? ConcurrencyStamp { get; }

        /// <summary>
        /// The create time-stamp expressed in Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? CreateStamp { get; }

        /// <summary>
        /// Delete request time-stamp of the entity expressed in the Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? DeleteStamp { get; }

        /// <summary>
        /// The locked state.
        /// </summary>
        bool? Disabled { get; }

        /// <summary>
        /// The entity id
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The locked state.
        /// </summary>
        bool? Locked { get; }

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
        /// The update time-stamp expressed in Coordinated Universal Time (UTC).
        /// </summary>
        DateTimeOffset? UpdateStamp { get; }
    }
}
