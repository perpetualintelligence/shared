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
    public class LicenseProvidersTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidlicenseUsage()
        {
            LicenseProviders.IsValid("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            LicenseProviders.IsValid(LicenseProviders.OneImlx).Should().BeTrue();
        }

        [Fact]
        public void LicenseProvidersConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseProviders), 1);

            LicenseProviders.OneImlx.Should().Be("urn:oneimlx:lic:pvdr:pi");
        }
    }
}