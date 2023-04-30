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
    public class LicenseSourceTests
    {
        [Fact]
        public void IsValidShouldReturnFalseForInvalidSource()
        {
            LicenseSources.IsValid("invalid").Should().BeFalse();
        }

        [Fact]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            LicenseSources.IsValid(LicenseSources.JsonFile).Should().BeTrue();
        }

        [Fact]
        public void LicenseKeySourcesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseSources), 1);

            LicenseSources.JsonFile.Should().Be("urn:oneimlx:lic:source:jsonfile");
        }
    }
}