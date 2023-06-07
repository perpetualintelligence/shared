/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Shared.Comparers;
using PerpetualIntelligence.Test;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Defaults.Oidc
{
    public class OrderIndependentComparerTests : InitializerTests
    {
        public OrderIndependentComparerTests() : base(TestLogger.Create<OrderIndependentComparerTests>())
        {
        }

        [Fact]
        public void BothNullShouldEqual()
        {
            string? x = null;
            string? y = null;
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void CodeCodeSameValuesShouldEqual()
        {
            string x = "code";
            string y = "code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void CodeIdTokenEitherWayShouldEqual()
        {
            string x = "code id_token";
            string y = "id_token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void CodeIdTokenTokenEitherWayShouldEqual()
        {
            string x = "code id_token token";
            string y = "token id_token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void CodeIdTokenTokenMixedWayShouldEqual()
        {
            string x = "code id_token token";
            string y = "id_token code token";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void CodeIdTokenTokenNoCodeShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "id_token token";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void CodeIdTokenTokenNoCodeTokenShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "id_token";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void CodeIdTokenTokenSameLengthDifferentWordsShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "code longwordtoken7";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void CodeTokenBothWaysShouldEqual()
        {
            string x = "code token";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void DifferentWordsSameLengthTokenCodeShouldNotEqual()
        {
            string x = "seven four";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void FirstNullOtherEmptyShouldNotEqual()
        {
            string? x = null;
            string y = string.Empty;
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void GetHashValueShouldReturnCorrectly()
        {
            OrderIndependentComparer comparer = new();
            comparer.GetHashCode(null).Should().Be(0);

            comparer.GetHashCode("test_value").Should().Be("test_value".GetHashCode());

            int hcode1 = comparer.GetHashCode("token code id_token");
            int hcode2 = comparer.GetHashCode("token code id_token");

            hcode2.Should().NotBe(hcode1);
        }

        [Fact]
        public void IdTokenCodeIdTokenCodeSameValuesShouldEqual()
        {
            string x = "id_token code";
            string y = "id_token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void IdTokenCodeTokenCodeDifferentValueShouldNotEqual()
        {
            string x = "id_token code";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }

        [Fact]
        public void IdTokenTokenBothWaysShouldEqual()
        {
            string x = "id_token token";
            string y = "token id_token";
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeTrue();
        }

        [Fact]
        public void SecondNullOtherEmptyShouldNotEqual()
        {
            string x = string.Empty;
            string? y = null;
            OrderIndependentComparer comparer = new();
            comparer.Equals(x, y).Should().BeFalse();
        }
    }
}