/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/
/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    public class EmailListAttributeTests
    {
        [Fact]
        public void IsValidShouldReturnValidResult()
        {
            EmailListAttribute emailListAttribute = new();

            // null is valid
            emailListAttribute.IsValid(null).Should().BeTrue();
            emailListAttribute.IsValid(new string[] { "testemail1@test.com", "testemail2@test.com" }).Should().BeTrue();

            // must be list
            emailListAttribute.IsValid("testemail@test.com").Should().BeFalse();
            emailListAttribute.IsValid(new string[] { "testemail1", "testemail2@test.com" }).Should().BeFalse();
        }
    }
}