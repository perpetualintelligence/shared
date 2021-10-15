/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of an id accessor.
    /// </summary>
    /// <seealso cref="IIdGenerator"/>
    /// <seealso cref="IIdentityAccessor"/>
    public interface IIdAccessor
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        string GetId();
    }
}
