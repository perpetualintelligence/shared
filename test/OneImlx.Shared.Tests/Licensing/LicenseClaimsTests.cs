/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Shared.Infrastructure;
using System;
using System.Collections.Generic;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class LicenseClaimsTests
    {
        [Fact]
        public void LicenseClaims_Create_ShouldSetPropsCorrectly()
        {
            long exp = DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds();
            long iat = DateTimeOffset.UtcNow.AddHours(-1).ToUnixTimeSeconds();
            long nbf = DateTimeOffset.UtcNow.AddHours(-0.5).ToUnixTimeSeconds();

            var claims = new Dictionary<string, object>()
            {
                {"name", "test_name" },
                {"country", "test_country" },
                {"aud", "test_audience" },
                {"iss", "test_issuer" },
                {"jti", "test_jti" },
                {"sub", "test_subject" },
                {"tid", "test_tenantid" },
                {"azp", "test_azp" },
                {"acr", "test_acr1 test_acr2" },
                {"auth_apps", "test_app1 test_app2" },
                {"exp", exp },
                {"iat", iat },
                {"nbf",  nbf },
            };

            LicenseClaims licClaims = LicenseClaims.Create(claims);

            licClaims.TenantName.Should().Be("test_name");
            licClaims.TenantCountry.Should().Be("test_country");
            licClaims.Audience.Should().Be("test_audience");
            licClaims.Issuer.Should().Be("test_issuer");
            licClaims.Jti.Should().Be("test_jti");
            licClaims.Subject.Should().Be("test_subject");
            licClaims.TenantId.Should().Be("test_tenantid");
            licClaims.AuthorizedParty.Should().Be("test_azp");
            licClaims.AcrValues.Should().Be("test_acr1 test_acr2");
            licClaims.AuthorizedApplicationIds.Should().Be("test_app1 test_app2");
            licClaims.Expiry.Should().Be(DateTimeOffset.FromUnixTimeSeconds(exp));
            licClaims.IssuedAt.Should().Be(DateTimeOffset.FromUnixTimeSeconds(iat));
            licClaims.NotBefore.Should().Be(DateTimeOffset.FromUnixTimeSeconds(nbf));

            licClaims.Custom.Should().BeNull();
        }

        [Fact]
        public void LicenseClaimsWithCustom_Create_ShouldSetPropsCorrectly()
        {
            long exp = DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds();
            long iat = DateTimeOffset.UtcNow.AddHours(-1).ToUnixTimeSeconds();
            long nbf = DateTimeOffset.UtcNow.AddHours(-0.5).ToUnixTimeSeconds();

            var claims = new Dictionary<string, object>()
            {
                {"name", "test_name" },
                {"country", "test_country" },
                {"aud", "test_audience" },
                {"iss", "test_issuer" },
                {"jti", "test_jti" },
                {"sub", "test_subject" },
                {"tid", "test_tenantid" },
                {"azp", "test_azp" },
                {"acr", "test_acr1 test_acr2" },
                {"auth_apps", "test_app1 test_app2" },
                {"exp", exp },
                {"iat", iat },
                {"nbf",  nbf },
                {"custom1",  "value1" },
                {"custom2",  false },
                {"custom3",  25 },
                {"custom4",  new string[] {"val1", "val2", "val3" } },
                {"custom5",  36.69 },
            };

            LicenseClaims licClaims = LicenseClaims.Create(claims);

            licClaims.TenantName.Should().Be("test_name");
            licClaims.TenantCountry.Should().Be("test_country");
            licClaims.Audience.Should().Be("test_audience");
            licClaims.Issuer.Should().Be("test_issuer");
            licClaims.Jti.Should().Be("test_jti");
            licClaims.Subject.Should().Be("test_subject");
            licClaims.TenantId.Should().Be("test_tenantid");
            licClaims.AuthorizedParty.Should().Be("test_azp");
            licClaims.AcrValues.Should().Be("test_acr1 test_acr2");
            licClaims.AuthorizedApplicationIds.Should().Be("test_app1 test_app2");
            licClaims.Expiry.Should().Be(DateTimeOffset.FromUnixTimeSeconds(exp));
            licClaims.IssuedAt.Should().Be(DateTimeOffset.FromUnixTimeSeconds(iat));
            licClaims.NotBefore.Should().Be(DateTimeOffset.FromUnixTimeSeconds(nbf));

            // Custom claims
            licClaims.Custom.Should().NotBeNull();
            licClaims.Custom!.Count.Should().Be(5);
            licClaims.Custom["custom1"].Should().Be("value1");
            licClaims.Custom["custom2"].Should().Be(false);
            licClaims.Custom["custom3"].Should().Be(25);
            licClaims.Custom["custom4"].Should().BeEquivalentTo(new string[] { "val1", "val2", "val3" });
            licClaims.Custom["custom5"].Should().Be(36.69);
        }

        [Fact]
        public void LicenseClaimsWithOptional_Create_ShouldSetPropsCorrectly()
        {
            long exp = DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds();
            long iat = DateTimeOffset.UtcNow.AddHours(-1).ToUnixTimeSeconds();
            long nbf = DateTimeOffset.UtcNow.AddHours(-0.5).ToUnixTimeSeconds();

            var claims = new Dictionary<string, object>()
            {
                {"name", "test_name" },
                {"country", "test_country" },
                {"aud", "test_audience" },
                {"iss", "test_issuer" },
                {"jti", "test_jti" },
                {"sub", "test_subject" },
                {"tid", "test_tenantid" },
                {"azp", "test_azp" },
                {"acr", "test_acr1 test_acr2" },
                {"auth_apps", "test_app1 test_app2" },
                {"exp", exp },
                {"iat", iat },
                {"nbf",  nbf },
            };

            LicenseClaims licClaims = LicenseClaims.Create(claims);

            licClaims.TenantName.Should().Be("test_name");
            licClaims.TenantCountry.Should().Be("test_country");
            licClaims.Audience.Should().Be("test_audience");
            licClaims.Issuer.Should().Be("test_issuer");
            licClaims.Jti.Should().Be("test_jti");
            licClaims.Subject.Should().Be("test_subject");
            licClaims.TenantId.Should().Be("test_tenantid");
            licClaims.AuthorizedParty.Should().Be("test_azp");
            licClaims.AcrValues.Should().Be("test_acr1 test_acr2");
            licClaims.AuthorizedApplicationIds.Should().Be("test_app1 test_app2");
            licClaims.Expiry.Should().Be(DateTimeOffset.FromUnixTimeSeconds(exp));
            licClaims.IssuedAt.Should().Be(DateTimeOffset.FromUnixTimeSeconds(iat));
            licClaims.NotBefore.Should().Be(DateTimeOffset.FromUnixTimeSeconds(nbf));

            licClaims.Custom.Should().BeNull();
        }

        [Fact]
        public void MissingClaim_NameAsAnExample_ShouldThrowErrorException()
        {
            try
            {
                long exp = DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds();
                long iat = DateTimeOffset.UtcNow.AddHours(-1).ToUnixTimeSeconds();
                long nbf = DateTimeOffset.UtcNow.AddHours(-0.5).ToUnixTimeSeconds();

                var claims = new Dictionary<string, object>()
            {
                {"ctry", "test_country" },
                {"aud", "test_audience" },
                {"iss", "test_issuer" },
                {"jti", "test_jti" },
                {"sub", "test_subject" },
                {"tid", "test_tenantid" },
                {"azp", "test_azp" },
                {"acr", "test_acr1 test_acr2" },
                {"auth_apps", "test_app1 test_app2" },
                {"exp", exp },
                {"iat", iat },
                {"nbf",  nbf },
            };

                LicenseClaims licClaims = LicenseClaims.Create(claims);
            }
            catch (Exception ex)
            {
                ErrorException eex = (ErrorException)ex;
                eex.Error.ErrorCode.Should().Be("missing_claim");
                eex.Error.FormatDescription().Should().Be("The claim is missing in the request. info=The given key 'name' was not present in the dictionary.");
            }
        }
    }
}