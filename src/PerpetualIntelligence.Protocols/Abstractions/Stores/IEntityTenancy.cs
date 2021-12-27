/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
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
