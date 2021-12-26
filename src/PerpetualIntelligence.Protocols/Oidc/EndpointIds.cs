/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>oneimlx</c> endpoint identifiers.
    /// </summary>
    [WriteDocumentation]
    [MustDo("Add links to OpenID connect standard for each endpoint.", BlockRelease = true)]
    public static class EndpointIds
    {
        /// <summary>
        /// The authorization endpoint.
        /// </summary>
        public const string Authorize = "urn:oneimlx:auth";

        /// <summary>
        /// The authorization callback endpoint.
        /// </summary>
        public const string AuthorizeCallback = "urn:oneimlx:authcb";

        /// <summary>
        /// The check session endpoint.
        /// </summary>
        public const string CheckSession = "urn:oneimlx:checksession";

        /// <summary>
        /// The device authorization endpoint.
        /// </summary>
        public const string DeviceAuthorization = "urn:oneimlx:device";

        /// <summary>
        /// The discovery well known configuration.
        /// </summary>
        public const string DiscoveryConfiguration = "urn:oneimlx:discovery";

        /// <summary>
        /// The discovery json web keys endpoint.
        /// </summary>
        public const string DiscoveryWebKeys = "urn:oneimlx:jwks";

        /// <summary>
        /// The end session endpoint.
        /// </summary>
        public const string EndSession = "urn:oneimlx:endsession";

        /// <summary>
        /// The end session callback endpoint.
        /// </summary>
        public const string EndSessionCallback = "urn:oneimlx:endsessioncb";

        /// <summary>
        /// The introspection callback endpoint.
        /// </summary>
        public const string Introspection = "urn:oneimlx:introspection";

        /// <summary>
        /// The revocation callback endpoint.
        /// </summary>
        public const string Revocation = "urn:oneimlx:revocation";

        /// <summary>
        /// The token endpoint.
        /// </summary>
        public const string Token = "urn:oneimlx:token";

        /// <summary>
        /// The user information endpoint.
        /// </summary>
        public const string UserInfo = "urn:oneimlx:userinfo";
    }
}
