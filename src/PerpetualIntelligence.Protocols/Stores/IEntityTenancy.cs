/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
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
