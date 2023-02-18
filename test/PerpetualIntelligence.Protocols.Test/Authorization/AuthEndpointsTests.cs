/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Protocols.Authorization
{
    public class AuthEndpointsTests
    {
        [Fact]
        public void B2CIssuer_Should_Format_Correct()
        {
            AuthEndpoints.MsalB2CIssuer("test_tenant", "test_id").Should().Be("https://test_tenant.b2clogin.com/test_id/v2.0/");
        }

        [Fact]
        public void B2COpenIdConfiguration_Should_Format_Correct()
        {
            AuthEndpoints.MsalB2COpenIdConfiguration("test_tenant", "test_policy").Should().Be("https://test_tenant.b2clogin.com/test_tenant.onmicrosoft.com/test_policy/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void Issuer_ShouldBe_Correct()
        {
            AuthEndpoints.MsalIssuer.Should().Be("https://login.microsoftonline.com/{0}/v2.0");
        }

        [Fact]
        public void IssuerB2C_ShouldBe_Correct()
        {
            AuthEndpoints.MsalIssuerB2C.Should().Be("https://{0}.b2clogin.com/{1}/v2.0/");
        }

        [Fact]
        public void PiB2CIssuer_ShouldBe_Correct()
        {
            AuthEndpoints.PiB2CIssuer("test_tenant").Should().Be("https://login.perpetualintelligence.com/test_tenant/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void PiB2CTenantName_ShouldBe_Correct()
        {
            AuthEndpoints.PiB2CTenantName.Should().Be("perpetualintelligenceb2c");
        }

        [Fact]
        public void OpenIdConfiguration_ShouldBe_Correct()
        {
            AuthEndpoints.MsalOpenIdConfiguration.Should().Be("https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void OpenIdConfigurationB2C_ShouldBe_Correct()
        {
            AuthEndpoints.MsalOpenIdConfigurationB2C.Should().Be("https://{0}.b2clogin.com/{0}.onmicrosoft.com/{1}/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void TenantIssuer_Should_Format_Correct()
        {
            AuthEndpoints.MsalTenantIssuer("test_id").Should().Be("https://login.microsoftonline.com/test_id/v2.0");
        }

        [Fact]
        public void TenantOpenIdConfiguration_Should_Format_Correct()
        {
            AuthEndpoints.MsalTenantOpenIdConfiguration("test_id").Should().Be("https://login.microsoftonline.com/test_id/v2.0/.well-known/openid-configuration");
        }
    }
}