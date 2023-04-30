/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Security
{
    public class IdGeneratorTests
    {
        [Fact]
        public void NewGuidTest()
        {
            IdGenerator.NewGuid().Should().NotBeNull();
        }

        [Fact]
        public void NewLongIdTest()
        {
            string id = IdGenerator.NewLongId();
            id.Should().NotBeNull();
            id.Contains('-').Should().BeFalse();
        }

        [Fact]
        public void NewShortIdTest()
        {
            string id = IdGenerator.NewShortId();
            id.Should().NotBeNull();
            id.Contains("[/+= -]").Should().BeFalse();
        }
    }
}