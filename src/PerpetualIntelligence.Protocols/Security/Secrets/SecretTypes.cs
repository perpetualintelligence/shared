/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Security.Cryptography.X509Certificates;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    /// <summary>
    /// Defines the secret types.
    /// </summary>
    public static class SecretTypes
    {
        /// <summary>
        /// The JSON Web Key (JWK). See <see href="https://datatracker.ietf.org/doc/html/rfc7517"/>.
        /// </summary>
        public const string JsonWebKey = "urn:oneimlx:security:secret:jwk";

        /// <summary>
        /// The JWT bearer token. See <see href="https://datatracker.ietf.org/doc/html/rfc7523"/>.
        /// </summary>
        [MustDo("For consistency make this urn:oneimlx:", BlockRelease = true)]
        public const string JwtBearer = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";

        /// <summary>
        /// No secret type.
        /// </summary>
        public const string None = "urn:oneimlx:security:secret:none";

        /// <summary>
        /// The regular plain text that an application gives to an authorized secret owner.
        /// </summary>
        public const string Plain = "urn:oneimlx:security:secret:pln";

        /// <summary>
        /// The SHA hash an application gives to an authorized secret owner.
        /// </summary>
        public const string Sha = "urn:oneimlx:security:secret:sha";

        /// <summary>
        /// The <see cref="X509Certificate2"/> Base64 encoding.
        /// </summary>
        public const string X509Base64 = "urn:oneimlx:security:secret:x509b64";

        /// <summary>
        /// The <see cref="X509Certificate2"/> Mtls.
        /// </summary>
        public const string X509Mtls = "urn:oneimlx:security:secret:x509mtls";

        /// <summary>
        /// The <see cref="X509Certificate2"/> subject's distinguished name.
        /// </summary>
        public const string X509Subject = "urn:oneimlx:security:secret:x509sub";

        /// <summary>
        /// The <see cref="X509Certificate2"/> thumbprint.
        /// </summary>
        public const string X509Thumbprint = "urn:oneimlx:security:secret:x509tb";
    }
}
