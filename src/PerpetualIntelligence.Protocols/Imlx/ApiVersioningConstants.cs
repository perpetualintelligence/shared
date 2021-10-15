/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The Perpetual Intelligence and Swagger API integration constants.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    [InternalInfrastructure]
    public static class ApiVersioningConstants
    {
        /// <summary>
        /// V1 version of Perpetual Intelligence Identity service.
        /// </summary>
        public const string V1IdentityGroup = "v1imlxidentity";

        /// <summary>
        /// V1 version of Perpetual Intelligence internal services.
        /// </summary>
        public const string V1InternalGroup = "v1imlxinternal";

        /// <summary>
        /// V1 version of Perpetual Intelligence OpenId Connect service.
        /// </summary>
        public const string V1OidcGroup = "v1imlxoidc";

        /// <summary>
        /// The v1 version identifier in the URL.
        /// </summary>
        public const string V1Url = "v1";

        /// <summary>
        /// The v1 version identifier.
        /// </summary>
        public const string V1 = "1.0";
    }
}
