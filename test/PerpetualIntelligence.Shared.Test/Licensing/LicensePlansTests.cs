/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Licensing
{
    public class LicensePlansTests
    {
        [Fact]
        public void IsValidShouldReturnTrueForValidlicensePlans()
        {
            LicensePlans.IsValidPiCliPlan(LicensePlans.Demo).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.Micro).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.SMB).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.Enterprise).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.OnPremise).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.Unlimited).Should().BeTrue();
            LicensePlans.IsValidPiCliPlan(LicensePlans.Custom).Should().BeTrue();
        }

        [Fact]
        public void IsValidShouldReturnFalseForInvalidlicensePlans()
        {
            LicensePlans.IsValidPiCliPlan("invalid").Should().BeFalse();
        }

        [Fact]
        public void LicensePlansConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicensePlans), 7);

            LicensePlans.Demo.Should().Be("urn:oneimlx:lic:plan:demo");
            LicensePlans.Micro.Should().Be("urn:oneimlx:lic:plan:micro");
            LicensePlans.SMB.Should().Be("urn:oneimlx:lic:plan:smb");
            LicensePlans.Enterprise.Should().Be("urn:oneimlx:lic:plan:enterprise");
            LicensePlans.OnPremise.Should().Be("urn:oneimlx:lic:plan:onprem");
            LicensePlans.Unlimited.Should().Be("urn:oneimlx:lic:plan:unlimited");
            LicensePlans.Custom.Should().Be("urn:oneimlx:lic:plan:custom");
        }
    }
}