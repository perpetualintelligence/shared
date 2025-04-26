/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Microsoft.IdentityModel.JsonWebTokens;
using OneImlx.Shared.Infrastructure;
using OneImlx.Shared.Security;
using OneImlx.Test.FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class LicenseX509ServiceTests : IClassFixture<X509CertificateFixture>
    {
        public LicenseX509ServiceTests(X509CertificateFixture fixture)
        {
            _certificate = fixture.Certificate;
        }

        [Fact]
        public void FromJwtValidationKey_WithoutPkeyClaim_ShouldThrowInvalidTokenError()
        {
            var jwtWithoutPkey = CreateJwtWithoutPKeyClaim();

            Action act = () => LicenseX509Service.FromJwtValidationKey(jwtWithoutPkey, out _);

            act.Should().Throw<ErrorException>()
                .WithErrorCode("invalid_token")
                .WithErrorDescription("The pkey claim is missing in the token.");
        }

        [Fact]
        public void FromJwtValidationKey_WithPrivateKeyInPkey_ShouldThrowUnauthorizedAccessError()
        {
            // Use the test certificate with a private key for this scenario
            var jwtWithPrivateKey = CreateJwtWithPrivateKeyClaim(_certificate);

            Action act = () => LicenseX509Service.FromJwtValidationKey(jwtWithPrivateKey, out _);

            act.Should().Throw<ErrorException>()
                .WithErrorCode("unauthorized_access")
                .WithErrorDescription("The validation certificate cannot have a private key.");
        }

        [Fact]
        public void FromJwtValidationKey_WithValidJwt_ShouldExtractPublicKey()
        {
            var jwt = LicenseX509Service.ToJwtValidationKey(_certificate);
            var publicKey = LicenseX509Service.FromJwtValidationKey(jwt, out X509Certificate2 x509Certificate);

            publicKey.Should().NotBeNullOrEmpty();
            x509Certificate.HasPrivateKey.Should().BeFalse();

            byte[] pKeyBytes = _certificate.Export(X509ContentType.Cert);
            string pKey = Convert.ToBase64String(pKeyBytes);

            publicKey.Should().Be(pKey);
            publicKey.Should().NotBe(jwt);
        }

        [Fact]
        public void ToJwtValidationKey_WithValidCertificate_ShouldContainPublicKey()
        {
            var jwt = LicenseX509Service.ToJwtValidationKey(_certificate);

            byte[] pKeyBytes = _certificate.Export(X509ContentType.Cert);
            string pKey = Convert.ToBase64String(pKeyBytes);

            jwt.Should().NotBeNullOrEmpty();
            var handler = new JsonWebTokenHandler();
            var token = handler.ReadJsonWebToken(jwt);

            token.Claims.Should().HaveCount(1);

            Claim pKeyClaims = token.Claims.First(claim => claim.Type == "pkey");
            pKeyClaims.Value.Should().NotBeNullOrEmpty();
            pKeyClaims.Value.Should().Be(pKey);
        }

        [Fact]
        public void ToSigningCertificate_WithoutPrivateKey_ShouldThrowErrorException()
        {
            var publicKeyCert = Convert.ToBase64String(_certificate.Export(X509ContentType.Cert));

            Action act = () => LicenseX509Service.ToSigningCertificate(publicKeyCert);

            act.Should().Throw<ErrorException>()
                .WithErrorCode("unauthorized_access")
                .WithErrorDescription("The signing certificate must have a private key.");
        }

        [Fact]
        public void ToSigningCertificate_WithValidCertificate_ShouldContainPrivateKey()
        {
            var base64Cert = Convert.ToBase64String(_certificate.Export(X509ContentType.Pkcs12, "password"));
            var signingCert = LicenseX509Service.ToSigningCertificate(base64Cert, "password");
            signingCert.HasPrivateKey.Should().BeTrue();
            signingCert.Should().Be(_certificate);
        }

        private string CreateJwtWithoutPKeyClaim()
        {
            var claims = new Dictionary<string, object>
            {
                // Intentionally leaving out the "pkey" claim to simulate the error condition
                {"someOtherClaim", "someValue"}
            };

            string payload = JsonSerializer.Serialize(claims);
            var tokenHandler = new JsonWebTokenHandler();
            return tokenHandler.CreateToken(payload);
        }

        private string CreateJwtWithPrivateKeyClaim(X509Certificate2 certificateWithPrivateKey)
        {
            // Export the private key, this method varies depending on the certificate storage, here assuming RSA
            var privateKeyBytes = certificateWithPrivateKey.Export(X509ContentType.Pfx);
            string encodedPrivateKey = Convert.ToBase64String(privateKeyBytes);

            var claims = new Dictionary<string, object>
            {
                {"pkey", encodedPrivateKey} // Incorrectly placing the private key in the pkey claim
            };

            string payload = JsonSerializer.Serialize(claims);
            var tokenHandler = new JsonWebTokenHandler();
            return tokenHandler.CreateToken(payload); // Create the JWT with the maliciously formed claim
        }

        private readonly X509Certificate2 _certificate;
    }
}
