/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using System;
using Xunit;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    public class ErrorTests
    {
        [Fact]
        public void CtorNoErrorCodeShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error(null, "test"), "'error' cannot be null or whitespace. (Parameter 'error')");
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("   ", "test"), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [Fact]
        public void CtorNoErrorDescriptionShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("test", null), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("test", "   "), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [Fact]
        public void CtorShouldSetCorrectly()
        {
            Error error = new("error", "desc", null, "uri", "rid");
            error.ErrorCode.Should().Be("error");
            error.ErrorDescription.Should().Be("desc"); ;
            error.ErrorUri.Should().Be("uri");
            error.RequestId.Should().Be("rid");
            error.Args.Should().BeNull();
        }

        [Fact]
        public void JsonPropertyNameShouldBeValid()
        {
            Type type = typeof(Error);
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorCode)), "error");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorDescription)), "error_description");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorUri)), "error_uri");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.RequestId)), "request_id");
        }

        [Fact]
        public void SetErrorNoErrorDescriptionShouldThrow()
        {
            var error = new Error("err", "desc");

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("test1", null), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("test1", "   "), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
        }

        [Fact]
        public void SetErrorNoErrorShouldThrow()
        {
            var error = new Error("err", "desc");

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError(null, "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("   ", "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [Fact]
        public void SetErrorShouldSetCorrectly()
        {
            Error error = new Error("err", "desc");
            error.SetError("error", "desc", new[] { "test1", "test2" }, "uri", "rid");
            error.ErrorCode.Should().Be("error");
            error.ErrorDescription.Should().Be("desc");
            error.ErrorUri.Should().Be("uri");
            error.RequestId.Should().Be("rid");
            error.Args.Should().ContainInOrder(new[] { "test1", "test2" });
        }
    }
}