/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Security.Secrets
{
    public class SecretTypesTest
    {
        [Fact]
        public void SecretTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(SecretTypes), 9);

            SecretTypes.JsonWebKey.Should().Be("urn:oneimlx:security:secret:jwk");
            SecretTypes.JwtBearer.Should().Be("urn:ietf:params:oauth:client-assertion-type:jwt-bearer");
            SecretTypes.None.Should().Be("urn:oneimlx:security:secret:none");
            SecretTypes.Plain.Should().Be("urn:oneimlx:security:secret:pln");
            SecretTypes.Sha.Should().Be("urn:oneimlx:security:secret:sha");
            SecretTypes.X509Base64.Should().Be("urn:oneimlx:security:secret:x509b64");
            SecretTypes.X509Mtls.Should().Be("urn:oneimlx:security:secret:x509mtls");
            SecretTypes.X509Subject.Should().Be("urn:oneimlx:security:secret:x509sub");
            SecretTypes.X509Thumbprint.Should().Be("urn:oneimlx:security:secret:x509tb");
        }
    }
}