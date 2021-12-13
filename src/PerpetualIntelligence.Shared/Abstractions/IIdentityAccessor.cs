/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of an identity accessor.
    /// </summary>
    /// <remarks>
    /// The identity accessor returns see <see cref="Identity"/> of a target entity. It also implements
    /// <see cref="IIdAccessor"/> to return string representation of an <see cref="Identity"/>.
    /// </remarks>
    public interface IIdentityAccessor : IIdAccessor
    {
        /// <summary>
        /// Gets the identity.
        /// </summary>
        Identity GetIdentity();
    }
}
