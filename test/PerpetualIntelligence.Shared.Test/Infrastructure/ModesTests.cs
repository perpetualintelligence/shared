/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Shared.Exceptions;
using System;
using Xunit;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    public class ModesTests
    {
        [Fact]
        public void All()
        {
            string[] all = Modes.All();
            all.Length.Should().Be(4);

            all[0].Should().Be(Modes.Neutral);
            all[1].Should().Be(Modes.Test);
            all[2].Should().Be(Modes.Stage);
            all[3].Should().Be(Modes.Live);
        }

        [Fact]
        public void IsTestOrLiveTest()
        {
            Modes.IsTestOrLive(Modes.Live).Should().BeTrue();
            Modes.IsTestOrLive(Modes.Test).Should().BeTrue();

            Modes.IsTestOrLive("").Should().BeFalse();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Modes.IsTestOrLive(null).Should().BeFalse();
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Modes.IsTestOrLive("any").Should().BeFalse();

            Modes.IsTestOrLive(Modes.Neutral).Should().BeFalse();
            Modes.IsTestOrLive(Modes.Stage).Should().BeFalse();
        }

        [Fact]
        public void IsValidTest()
        {
            Modes.IsValid(Modes.Live).Should().BeTrue();
            Modes.IsValid(Modes.Test).Should().BeTrue();
            Modes.IsValid(Modes.Neutral).Should().BeTrue();
            Modes.IsValid(Modes.Stage).Should().BeTrue();

            Modes.IsValid("").Should().BeFalse();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Modes.IsValid(null).Should().BeFalse();
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Modes.IsValid("any").Should().BeFalse();
        }

        [Fact]
        public void ModesTest()
        {
            Modes.Live.Should().Be("urn:oneimlx:mode:live");
            Modes.Test.Should().Be("urn:oneimlx:mode:test");
            Modes.Neutral.Should().Be("urn:oneimlx:mode:neutral");
            Modes.Stage.Should().Be("urn:oneimlx:mode:stage");
        }

        [Fact]
        public void ThrowIdInvalid()
        {
            Action act = () => Modes.ThrowIfInvalid("random");
            act.Should().Throw<ErrorException>().WithMessage("Mode 'random' is not valid.");
        }
    }
}