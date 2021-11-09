/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The <c>oneimlx</c> endpoint identifiers.
    /// </summary>
    [ToDocumentation]
    [MustDo("Add links to OpenID connect standard for each endpoint.", BlockRelease = true)]
    public static class EndpointIds
    {
        /// <summary>
        /// The authorization endpoint.
        /// </summary>
        public const string Authorize = "urn:pi:protocols:imlx:auth";

        /// <summary>
        /// The authorization callback endpoint.
        /// </summary>
        public const string AuthorizeCallback = "urn:pi:protocols:imlx:authcb";

        /// <summary>
        /// The check session endpoint.
        /// </summary>
        public const string CheckSession = "urn:pi:protocols:imlx:check";

        /// <summary>
        /// The device authorization endpoint.
        /// </summary>
        public const string DeviceAuthorization = "urn:pi:protocols:imlx:device";

        /// <summary>
        /// The discovery well known configuration.
        /// </summary>
        public const string DiscoveryConfiguration = "urn:pi:protocols:imlx:discovery";

        /// <summary>
        /// The discovery json web keys endpoint.
        /// </summary>
        public const string DiscoveryWebKeys = "urn:pi:protocols:imlx:jwks";

        /// <summary>
        /// The end session endpoint.
        /// </summary>
        public const string EndSession = "urn:pi:protocols:imlx:end";

        /// <summary>
        /// The end session callback endpoint.
        /// </summary>
        public const string EndSessionCallback = "urn:pi:protocols:imlx:endcb";

        /// <summary>
        /// The introspection callback endpoint.
        /// </summary>
        public const string Introspection = "urn:pi:protocols:imlx:introspection";

        /// <summary>
        /// The revocation callback endpoint.
        /// </summary>
        public const string Revocation = "urn:pi:protocols:imlx:revocation";

        /// <summary>
        /// The token endpoint.
        /// </summary>
        public const string Token = "urn:pi:protocols:imlx:token";

        /// <summary>
        /// The user information endpoint.
        /// </summary>
        public const string UserInfo = "urn:pi:protocols:imlx:userinfo";
    }
}
