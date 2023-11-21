/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    public class OneOfAttributeTests
    {
        [Fact]
        public void IsValidArrayShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            OneOfAttribute allowedAttribute = new(allowed);

            allowedAttribute.IsValid(new string[] { "test1", "test2" }).Should().BeTrue();

            allowedAttribute.IsValid(new string[] { "test1", "test5" }).Should().BeFalse();

            // null is valid, this is useful for data validation when nothing is entered
            allowedAttribute.IsValid(null).Should().BeTrue();
        }

        [Fact]
        public void IsValidShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            OneOfAttribute allowedAttribute = new(allowed);

            allowedAttribute.IsValid("test1").Should().BeTrue();
            allowedAttribute.IsValid("test2").Should().BeTrue();
            allowedAttribute.IsValid("test5").Should().BeFalse();

            // null is valid, this is useful for data validation when nothing is entered
            allowedAttribute.IsValid(null).Should().BeTrue();
        }
    }
}