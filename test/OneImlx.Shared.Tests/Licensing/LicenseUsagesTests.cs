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
    public class LicenseUsagesTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidLicenseUsage()
        {
            LicenseUsages.IsValid("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            LicenseUsages.IsValid(LicenseUsages.CommercialBusiness).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.CommercialSolo).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.Educational).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.RnD).Should().BeTrue();
        }

        [Fact]
        public void LicenseUsagesConstTest()
        {
            typeof(LicenseUsages).Should().HaveConstantCount(4);

            LicenseUsages.CommercialBusiness.Should().Be("urn:oneimlx:lic:usage:org");
            LicenseUsages.CommercialSolo.Should().Be("urn:oneimlx:lic:usage:per");
            LicenseUsages.Educational.Should().Be("urn:oneimlx:lic:usage:edu");
            LicenseUsages.RnD.Should().Be("urn:oneimlx:lic:usage:rnd");
        }
    }
}