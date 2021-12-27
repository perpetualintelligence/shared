/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The <c>oneimlx</c> and Swagger API integration constants.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    [InternalInfrastructure]
    public static class ApiVersioningConstants
    {
        /// <summary>
        /// The v1 version identifier.
        /// </summary>
        public const string V1 = "1.0";

        /// <summary>
        /// V1 version of Perpetual Intelligence Identity service.
        /// </summary>
        public const string V1IdentityGroup = "v1oneimlxidentity";

        /// <summary>
        /// V1 version of Perpetual Intelligence internal services.
        /// </summary>
        public const string V1InternalGroup = "v1oneimlxinternal";

        /// <summary>
        /// V1 version of Perpetual Intelligence OpenId Connect service.
        /// </summary>
        public const string V1OidcGroup = "v1oneimlxoidc";

        /// <summary>
        /// The v1 version identifier in the URL.
        /// </summary>
        public const string V1Url = "v1";
    }
}
