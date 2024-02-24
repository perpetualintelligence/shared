/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.FluentAssertions;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class LicenseUsageTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidLicenseUsage()
        {
            LicenseUsage.IsValid("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            LicenseUsage.IsValid(LicenseUsage.CommercialBusiness).Should().BeTrue();
            LicenseUsage.IsValid(LicenseUsage.CommercialSolo).Should().BeTrue();
            LicenseUsage.IsValid(LicenseUsage.Educational).Should().BeTrue();
            LicenseUsage.IsValid(LicenseUsage.RnD).Should().BeTrue();
        }

        [Fact]
        public void LicenseUsagesConstTest()
        {
            typeof(LicenseUsage).Should().HaveConstantCount(4);

            LicenseUsage.CommercialBusiness.Should().Be("urn:oneimlx:lic:usage:org");
            LicenseUsage.CommercialSolo.Should().Be("urn:oneimlx:lic:usage:solo");
            LicenseUsage.Educational.Should().Be("urn:oneimlx:lic:usage:edu");
            LicenseUsage.RnD.Should().Be("urn:oneimlx:lic:usage:rnd");
        }
    }
}