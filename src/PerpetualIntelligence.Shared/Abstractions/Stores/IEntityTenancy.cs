/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Abstractions.Stores
{
    /// <summary>
    /// Provides the tenancy information.
    /// </summary>
    public interface IEntityTenancy : IEntity
    {
        /// <summary>
        /// The tenant identifier.
        /// </summary>
        string TenantId { get; }

        /// <summary>
        /// The tenant mode.
        /// </summary>
        string? TenantMode { get; }
    }
}
