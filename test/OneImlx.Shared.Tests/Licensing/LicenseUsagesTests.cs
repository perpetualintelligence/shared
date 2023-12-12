/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.Services;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class LicenseUsagesTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidlicenseUsage()
        {
            LicenseUsages.IsValid("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            LicenseUsages.IsValid(LicenseUsages.CommercialBusiness).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.CommercialPersonal).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.Educational).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.RnD).Should().BeTrue();
            LicenseUsages.IsValid(LicenseUsages.None).Should().BeTrue();
        }

        [Fact]
        public void LicenseUsagesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseUsages), 5);

            LicenseUsages.CommercialBusiness.Should().Be("urn:oneimlx:lic:usage:org");
            LicenseUsages.CommercialPersonal.Should().Be("urn:oneimlx:lic:usage:per");
            LicenseUsages.Educational.Should().Be("urn:oneimlx:lic:usage:edu");
            LicenseUsages.RnD.Should().Be("urn:oneimlx:lic:usage:rnd");
            LicenseUsages.None.Should().Be("urn:oneimlx:lic:usage:none");
        }
    }
}