/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    public class RegexPatternsTest
    {
        [Fact]
        public void RegexPatternsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(RegexPatterns), 4);

            RegexPatterns.Letters.Should().Be("^[a-zA-Z]+$");

            RegexPatterns.LettersNumbersDashUnderscore.Should().Be("^([A-Za-z0-9-]_?)+$");

            RegexPatterns.LettersNumbersDashUnderscoreComma.Should().Be("^([A-Za-z0-9-]_,?)+$");

            RegexPatterns.LettersNumbersDashUnderscoreSpace.Should().Be("^([A-Za-z0-9][\\-\\h_]?)+$");
        }
    }
}