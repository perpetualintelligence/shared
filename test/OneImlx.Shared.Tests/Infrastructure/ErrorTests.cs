/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.Services;
using System;
using Xunit;

namespace OneImlx.Shared.Infrastructure
{
    public class ErrorTests
    {
        [Fact]
        public void CtorNoErrorCodeShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            Action act1 = () => new Error(null, "test");
            act1.Should().Throw<ArgumentException>().WithMessage("'errorCode' cannot be null or whitespace. (Parameter 'errorCode')");

            Action act2 = () => new Error("   ", "test");
            act2.Should().Throw<ArgumentException>().WithMessage("'errorCode' cannot be null or whitespace. (Parameter 'errorCode')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [Fact]
        public void CtorNoErrorDescriptionShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            Action act1 = () => new Error("test", null);
            act1.Should().Throw<ArgumentException>().WithMessage("'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");

            Action act2 = () => new Error("test", "   ");
            act2.Should().Throw<ArgumentException>().WithMessage("'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
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
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorCode)), "error_code");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorDescription)), "error_description");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorUri)), "error_uri");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.RequestId)), "request_id");
        }

        [Fact]
        public void NewInstanceShouldSetCorrectly()
        {
            Error error = new();
            error.ErrorCode.Should().Be("unknown_error");
            error.ErrorDescription.Should().Be("An unknown error occurred."); ;
            error.ErrorUri.Should().BeNull();
            error.RequestId.Should().BeNull();
            error.Args.Should().BeNull();
        }

        [Fact]
        public void SetErrorNoErrorDescriptionShouldThrow()
        {
            var error = new Error("err", "desc");

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act1 = () => error.SetError("test1", null);
            act1.Should().Throw<ArgumentException>().WithMessage("'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
            Action act2 = () => error.SetError("test1", "   ");
            act2.Should().Throw<ArgumentException>().WithMessage("'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [Fact]
        public void SetErrorNoErrorShouldThrow()
        {
            var error = new Error("err", "desc");

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act1 = () => error.SetError(null, "test1");
            act1.Should().Throw<ArgumentException>().WithMessage("'errorCode' cannot be null or whitespace. (Parameter 'errorCode')");
            Action act2 = () => error.SetError("   ", "test1");
            act2.Should().Throw<ArgumentException>().WithMessage("'errorCode' cannot be null or whitespace. (Parameter 'errorCode')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
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