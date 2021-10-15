/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Imlx;
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
