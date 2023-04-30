/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Security
{
    public class HexSaltGeneratorTests
    {
        [Fact]
        public void NewSaltIs32WithNoDashTest()
        {
            string salt = HexSaltGenerator.NewSalt();

            salt.Should().NotBeNull();
            salt.Contains('-').Should().BeFalse();

            // Salt is a Hex code. For 32 bits we have 64 chars Default is 32
            salt.Length.Should().Be(64);
        }

        [Fact]
        public void NewSaltLenghtHasDashTest()
        {
            string salt = HexSaltGenerator.NewSalt(32, strip: false);

            salt.Should().NotBeNull();
            salt.Contains('-').Should().BeTrue();

            // Salt is a Hex code for 32 bits we have 64 chars plus dahses
            salt.Length.Should().Be(95);
        }

        [Fact]
        public void NewSaltLengthDoesNotHaveDashTest()
        {
            string salt = HexSaltGenerator.NewSalt(64);

            salt.Should().NotBeNull();
            salt.Contains('-').Should().BeFalse();

            // Salt is a Hex code for 64 bits we have 124 chars
            salt.Length.Should().Be(128);
        }
    }
}