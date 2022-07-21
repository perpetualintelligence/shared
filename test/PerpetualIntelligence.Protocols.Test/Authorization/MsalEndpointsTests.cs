/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Protocols.Authorization
{
    public class MsalEndpointsTests
    {
        [Fact]
        public void B2CIssuer_Should_Format_Correct()
        {
            MsalEndpoints.B2CIssuer("test_tenant", "test_id").Should().Be("https://test_tenant.b2clogin.com/test_id/v2.0/");
        }

        [Fact]
        public void B2COpenIdConfiguration_Should_Format_Correct()
        {
            MsalEndpoints.B2COpenIdConfiguration("test_tenant", "test_policy").Should().Be("https://test_tenant.b2clogin.com/test_tenant.onmicrosoft.com/test_policy/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void Issuer_ShouldBe_Correct()
        {
            MsalEndpoints.Issuer.Should().Be("https://login.microsoftonline.com/{0}/v2.0");
        }

        [Fact]
        public void IssuerB2C_ShouldBe_Correct()
        {
            MsalEndpoints.IssuerB2C.Should().Be("https://{0}.b2clogin.com/{1}/v2.0/");
        }

        [Fact]
        public void OpenIdConfiguration_ShouldBe_Correct()
        {
            MsalEndpoints.OpenIdConfiguration.Should().Be("https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void OpenIdConfigurationB2C_ShouldBe_Correct()
        {
            MsalEndpoints.OpenIdConfigurationB2C.Should().Be("https://{0}.b2clogin.com/{0}.onmicrosoft.com/{1}/v2.0/.well-known/openid-configuration");
        }

        [Fact]
        public void TenantIssuer_Should_Format_Correct()
        {
            MsalEndpoints.TenantIssuer("test_id").Should().Be("https://login.microsoftonline.com/test_id/v2.0");
        }

        [Fact]
        public void TenantOpenIdConfiguration_Should_Format_Correct()
        {
            MsalEndpoints.TenantOpenIdConfiguration("test_id").Should().Be("https://login.microsoftonline.com/test_id/v2.0/.well-known/openid-configuration");
        }
    }
}
