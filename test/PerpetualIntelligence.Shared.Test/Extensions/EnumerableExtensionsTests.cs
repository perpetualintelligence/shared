/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace PerpetualIntelligence.Shared.Extensions
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void NonEmptyListButNullValueAndEmptyValueShouldNotReturnEmpty()
        {
            IEnumerable<string?>? list = new string?[] { "", null };
            list.IsNullOrEmpty().Should().BeFalse();
        }

        [Fact]
        public void NonEmptyListButNullValueAndNonEmptyValueShouldNotReturnEmpty()
        {
            IEnumerable<string?>? list = new string?[] { "test1", null };
            list.IsNullOrEmpty().Should().BeFalse();
        }

        [Fact]
        public void NonEmptyListButNullValueShouldNotReturnEmpty()
        {
            // Contains 1 element but that is null
            IEnumerable<string?>? list = new string?[] { null };
            list.IsNullOrEmpty().Should().BeFalse();
        }

        [Fact]
        public void NonEmptyListShouldNotReturnEmpty()
        {
            IEnumerable<string>? list = new[] { "test1", "test2" };
            list.IsNullOrEmpty().Should().BeFalse();
        }

        [Fact]
        public void NonNullListShouldReturnEmpty()
        {
            IEnumerable<string>? list = System.Array.Empty<string>();
            list.IsNullOrEmpty().Should().BeTrue();
        }

        [Fact]
        public void NullListShouldReturnEmpty()
        {
            IEnumerable<string>? list = null;
            list.IsNullOrEmpty().Should().BeTrue();
        }
    }
}