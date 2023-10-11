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
    public class TerminalLicensePlansTests
    {
        [Fact]
        public void IsValidShouldReturnTrueForValidLicensePlans()
        {
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Demo).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Micro).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.SMB).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Enterprise).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.OnPremise).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Unlimited).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Custom).Should().BeTrue();
        }

        [Fact]
        public void IsValidShouldReturnFalseForInvalidLicensePlans()
        {
            TerminalLicensePlans.IsValidPlan("invalid").Should().BeFalse();
        }

        [Fact]
        public void LicensePlansConstTest()
        {
            TestHelper.AssertConstantCount(typeof(TerminalLicensePlans), 7);

            TerminalLicensePlans.Demo.Should().Be("urn:oneimlx:lic:plan:demo");
            TerminalLicensePlans.Micro.Should().Be("urn:oneimlx:lic:plan:micro");
            TerminalLicensePlans.SMB.Should().Be("urn:oneimlx:lic:plan:smb");
            TerminalLicensePlans.Enterprise.Should().Be("urn:oneimlx:lic:plan:enterprise");
            TerminalLicensePlans.OnPremise.Should().Be("urn:oneimlx:lic:plan:onprem");
            TerminalLicensePlans.Unlimited.Should().Be("urn:oneimlx:lic:plan:unlimited");
            TerminalLicensePlans.Custom.Should().Be("urn:oneimlx:lic:plan:custom");
        }
    }
}