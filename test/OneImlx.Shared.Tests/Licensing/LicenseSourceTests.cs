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
            typeof(LicenseSources).Should().HaveConstantCount(1);

            LicenseSources.JsonFile.Should().Be("urn:oneimlx:lic:source:jsonfile");
        }
    }
}