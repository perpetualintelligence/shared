/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.FluentAssertions;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class TerminalLicensePlansTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidLicensePlans()
        {
            TerminalLicensePlans.IsValidPlan("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidLicensePlans()
        {
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Demo).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Solo).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Micro).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Smb).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Enterprise).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Corporate).Should().BeTrue();
            TerminalLicensePlans.IsValidPlan(TerminalLicensePlans.Custom).Should().BeTrue();
        }

        [Fact]
        public void LicensePlansConstTest()
        {
            typeof(TerminalLicensePlans).Should().HaveConstantCount(7);

            TerminalLicensePlans.Demo.Should().Be("urn:oneimlx:terminal:plan:demo");
            TerminalLicensePlans.Solo.Should().Be("urn:oneimlx:terminal:plan:solo");
            TerminalLicensePlans.Micro.Should().Be("urn:oneimlx:terminal:plan:micro");
            TerminalLicensePlans.Smb.Should().Be("urn:oneimlx:terminal:plan:smb");
            TerminalLicensePlans.Enterprise.Should().Be("urn:oneimlx:terminal:plan:enterprise");
            TerminalLicensePlans.Corporate.Should().Be("urn:oneimlx:terminal:plan:corporate");
            TerminalLicensePlans.Custom.Should().Be("urn:oneimlx:terminal:plan:custom");
        }
    }
}
