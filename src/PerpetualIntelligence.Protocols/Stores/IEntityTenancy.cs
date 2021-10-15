/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Stores
{
    /// <summary>
    /// Provides the tenancy information.
    /// </summary>
    public interface IEntityTenancy : IEntity
    {
        /// <summary>
        /// The tenant mode.
        /// </summary>
        string? TenantMode { get; }

        /// <summary>
        /// The tenant identifier.
        /// </summary>
        string TenantId { get; }
    }
}
