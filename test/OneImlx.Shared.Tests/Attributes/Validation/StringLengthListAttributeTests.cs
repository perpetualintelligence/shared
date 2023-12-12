/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    public class StringLengthListAttributeTests
    {
        [Fact]
        public void IsValidShouldReturnValidResult()
        {
            StringLengthListAttribute stringLengthListAttribute = new(8);

            // null is valid
            stringLengthListAttribute.IsValid(null).Should().BeTrue();
            stringLengthListAttribute.IsValid(new string[] { "testval1", "testval2" }).Should().BeTrue();

            // must be list
            stringLengthListAttribute.IsValid(new string[] { "testval1", "test_long_val2" }).Should().BeFalse();
        }
    }
}