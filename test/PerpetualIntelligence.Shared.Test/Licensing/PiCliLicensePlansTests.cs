/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Licensing
{
    public class PiCliLicensePlansTests
    {
        [Fact]
        public void IsValidShouldReturnTrueForValidlicensePlans()
        {
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.Demo).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.Micro).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.SMB).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.Enterprise).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.OnPremise).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.Unlimited).Should().BeTrue();
            PiCliLicensePlans.IsValidPlan(PiCliLicensePlans.Custom).Should().BeTrue();
        }

        [Fact]
        public void IsValidShouldReturnFalseForInvalidlicensePlans()
        {
            PiCliLicensePlans.IsValidPlan("invalid").Should().BeFalse();
        }

        [Fact]
        public void LicensePlansConstTest()
        {
            TestHelper.AssertConstantCount(typeof(PiCliLicensePlans), 7);

            PiCliLicensePlans.Demo.Should().Be("urn:oneimlx:lic:plan:demo");
            PiCliLicensePlans.Micro.Should().Be("urn:oneimlx:lic:plan:micro");
            PiCliLicensePlans.SMB.Should().Be("urn:oneimlx:lic:plan:smb");
            PiCliLicensePlans.Enterprise.Should().Be("urn:oneimlx:lic:plan:enterprise");
            PiCliLicensePlans.OnPremise.Should().Be("urn:oneimlx:lic:plan:onprem");
            PiCliLicensePlans.Unlimited.Should().Be("urn:oneimlx:lic:plan:unlimited");
            PiCliLicensePlans.Custom.Should().Be("urn:oneimlx:lic:plan:custom");
        }
    }
}