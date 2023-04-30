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
            LicenseProviders.IsValid(LicenseProviders.PerpetualIntelligence).Should().BeTrue();
        }

        [Fact]
        public void LicenseProvidersConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseProviders), 1);

            LicenseProviders.PerpetualIntelligence.Should().Be("urn:oneimlx:lic:pvdr:pi");
        }
    }
}