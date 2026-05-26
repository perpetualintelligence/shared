//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

using FluentAssertions;
using System;
using Xunit;

namespace OneImlx.Test.Extentions
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void NotNullShouldReturnSourceWhenNotNull()
        {
            string result = "hello".NotNull();
            result.Should().Be("hello");
        }

        [Fact]
        public void NotNullShouldThrowWhenNull()
        {
            string? value = null;
            FluentActions.Invoking(() => value.NotNull()).Should().Throw<Exception>();
        }

        [Fact]
        public void NotNullShouldReturnSameReferenceForObject()
        {
            var obj = new object();
            var result = obj.NotNull();
            result.Should().BeSameAs(obj);
        }

        [Fact]
        public void NotNullShouldWorkWithValueType()
        {
            int result = 42.NotNull();
            result.Should().Be(42);
        }
    }
}