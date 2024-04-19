/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.IdentityModel.JsonWebTokens;
using OneImlx.Shared.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The licensing services around <see cref="X509Certificate2"/>.
    /// </summary>
    public sealed class LicenseX509Service
    {
        /// <summary>
        /// Returns an unsigned <c>JWT</c> token containing the public key of a given certificate.
        /// </summary>
        /// <param name="certificate">The certificate containing the public key to be distributed.</param>
        /// <returns>An unsigned JWT token with the public key in the payload.</returns>
        /// <remarks>
        /// The method exports the public key from the provided <see cref="X509Certificate2"/> object,
        /// encodes it in Base64, and constructs an unsigned JWT token with the public key included
        /// in the payload under the <c>pkey</c> claim. This JWT token does not contain a signature or expiration,
        /// making it suitable for public distribution.
        /// </remarks>
        public static string ToJwtValidationKey(X509Certificate2 certificate)
        {
            // Extract the public key from the certificate and encode it using Base64.
            byte[] publicKeyBytes = certificate.Export(X509ContentType.Cert);
            string encodedPublicKey = Convert.ToBase64String(publicKeyBytes);

            // Construct the payload with the public key.
            var claims = new Dictionary<string, object>
            {
                {"pkey", encodedPublicKey}
            };

            // Serialize the claims to JSON for the JWT payload.
            string payload = JsonSerializer.Serialize(claims);

            // Create the JWT token without signing.
            var tokenHandler = new JsonWebTokenHandler();
            var token = tokenHandler.CreateToken(payload);

            return token;
        }

        /// <summary>
        /// Returns the public validation key and certificate from a JWT token.
        /// </summary>
        /// <param name="jwtVKey">The JWT from which the public validation key is extracted.</param>
        /// <param name="x509Certificate">Outputs the X509Certificate2 created from the extracted public key.</param>
        /// <returns>The extracted public validation key.</returns>
        /// <exception cref="ErrorException">
        /// Thrown if the JWT does not contain a <c>pkey</c> claim indicating the public validation key, or if the generated
        /// certificate inadvertently contains a private key, indicating unauthorized access.
        /// </exception>
        public static string FromJwtValidationKey(string jwtVKey, out X509Certificate2 x509Certificate)
        {
            // Instantiate a handler for processing the JWT.
            JsonWebTokenHandler tokenHandler = new();

            // Read the JWT to extract its payload.
            JsonWebToken token = tokenHandler.ReadJsonWebToken(jwtVKey);

            // Look for the 'pkey' claim which should contain the public key.
            Claim? pKeyClaim = token.Claims.FirstOrDefault(claim => claim.Type == "pkey");
            if (pKeyClaim == null)
            {
                throw new ErrorException("invalid_token", "The pkey claim is missing in the token.");
            }

            // Decode the public key from its Base64 representation.
            byte[] publicKeyBytes = Convert.FromBase64String(pKeyClaim.Value);

            // Initialize the X509Certificate2 with the public key.
            x509Certificate = new X509Certificate2(publicKeyBytes);

            // Ensure the certificate does not mistakenly include a private key.
            if (x509Certificate.HasPrivateKey)
            {
                throw new ErrorException("unauthorized_access", "The validation certificate cannot have a private key.");
            }

            // Return the public key.
            return pKeyClaim.Value;
        }

        /// <summary>
        /// Returns the signing certificate.
        /// </summary>
        public static X509Certificate2 ToSigningCertificate(string cert, string? pwd = null)
        {
            X509Certificate2 signCert = new(Convert.FromBase64String(cert), pwd);
            if (!signCert.HasPrivateKey)
            {
                throw new ErrorException("unauthorized_access", "The signing certificate must have a private key.");
            }
            return signCert;
        }
    }
}