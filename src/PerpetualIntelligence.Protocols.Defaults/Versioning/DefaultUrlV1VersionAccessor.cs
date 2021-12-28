/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Protocols.OneImlx;
using PerpetualIntelligence.Shared.Abstractions;

namespace PerpetualIntelligence.Protocols.Defaults.Versioning
{
    /// <summary>
    /// The default <see cref="IUrlVersionAccessor"/> for <c>v1</c>.
    /// </summary>
    public class DefaultUrlV1VersionAccessor : IUrlVersionAccessor
    {
        /// <inheritdoc/>
        public virtual string GetVersion()
        {
            return ApiVersioningConstants.V1Url;
        }
    }
}
