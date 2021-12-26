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
    public static class EndpointNames
    {
        /// <summary>
        /// The authorization endpoint.
        /// </summary>
        public const string Authorize = "authorize";

        /// <summary>
        /// The check session endpoint.
        /// </summary>
        public const string CheckSession = "check_session";

        /// <summary>
        /// The device authorization endpoint.
        /// </summary>
        public const string DeviceAuthorization = "device_authorization";

        /// <summary>
        /// The discovery well known configuration.
        /// </summary>
        public const string Discovery = "discovery";

        /// <summary>
        /// The end session endpoint.
        /// </summary>
        public const string EndSession = "end_session";

        /// <summary>
        /// The introspection callback endpoint.
        /// </summary>
        public const string Introspection = "introspection";

        /// <summary>
        /// The revocation callback endpoint.
        /// </summary>
        public const string Revocation = "revocation";

        /// <summary>
        /// The token endpoint.
        /// </summary>
        public const string Token = "token";

        /// <summary>
        /// The user information endpoint.
        /// </summary>
        public const string UserInfo = "user_info";
    }
}
