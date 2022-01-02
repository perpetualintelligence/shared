/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
        /// <returns>An identifier.</returns>
        string GetId();
    }
}
