/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    public class UrlListAttributeTests
    {
        [Fact]
        public void IsValidShouldReturnValidResult()
        {
            UrlListAttribute urlListAttribute = new();

            // null is valid
            urlListAttribute.IsValid(null).Should().BeTrue();
            urlListAttribute.IsValid(new string[] { "http://testurl", "https://testurl2", "ftp://testurl3" }).Should().BeTrue();

            urlListAttribute.IsValid(new string?[] { null, "https://testurl2", "ftp://testurl3" }).Should().BeFalse();
            urlListAttribute.IsValid(new string[] { "invalid_url", "https://testurl2", "ftp://testurl3" }).Should().BeFalse();
        }
    }
}