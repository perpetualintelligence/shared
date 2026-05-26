//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

using FluentAssertions;
using FluentAssertions.Execution;
using OneImlx.Shared.Infrastructure;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OneImlx.Test.FluentAssertions
{
    public class ErrorExceptionFluentAssertionsTests
    {
        [Fact]
        public void WithErrorCodeShouldPassWhenErrorCodeMatches()
        {
            Action act = () => throw new ErrorException(new Error("err_test", "Something went wrong."));
            act.Should().Throw<ErrorException>().WithErrorCode("err_test");
        }

        [Fact]
        public void WithErrorCodeShouldFailWhenErrorCodeDoesNotMatch()
        {
            Action act = () => throw new ErrorException(new Error("err_test", "Something went wrong."));
            FluentActions.Invoking(() =>
                act.Should().Throw<ErrorException>().WithErrorCode("wrong_code"))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void WithErrorCodeShouldFailWhenExceptionIsNotErrorException()
        {
            Action act = () => throw new InvalidOperationException("not an ErrorException");
            FluentActions.Invoking(() =>
                act.Should().Throw<InvalidOperationException>().WithErrorCode("err_test"))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void WithErrorDescriptionShouldPassWhenDescriptionMatches()
        {
            Action act = () => throw new ErrorException(new Error("err_test", "Something went wrong."));
            act.Should().Throw<ErrorException>().WithErrorDescription("Something went wrong.");
        }

        [Fact]
        public void WithErrorDescriptionShouldFailWhenDescriptionDoesNotMatch()
        {
            Action act = () => throw new ErrorException(new Error("err_test", "Something went wrong."));
            FluentActions.Invoking(() =>
                act.Should().Throw<ErrorException>().WithErrorDescription("Wrong description."))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void WithErrorShouldPassWhenErrorMatches()
        {
            var error = new Error("err_test", "Something went wrong.");
            Action act = () => throw new ErrorException(error);
            act.Should().Throw<ErrorException>().WithError(error);
        }

        [Fact]
        public void WithErrorShouldFailWhenErrorDoesNotMatch()
        {
            var error = new Error("err_test", "Something went wrong.");
            var differentError = new Error("err_other", "Other error.");
            Action act = () => throw new ErrorException(error);
            FluentActions.Invoking(() =>
                act.Should().Throw<ErrorException>().WithError(differentError))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public async Task WithErrorCodeAsyncShouldPassWhenErrorCodeMatches()
        {
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(new Error("err_async", "Async error."));
            };

            await act.Should().ThrowAsync<ErrorException>().WithErrorCode("err_async");
        }

        [Fact]
        public async Task WithErrorCodeAsyncShouldFailWhenErrorCodeDoesNotMatch()
        {
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(new Error("err_async", "Async error."));
            };

            await FluentActions.Awaiting(async () =>
                await act.Should().ThrowAsync<ErrorException>().WithErrorCode("wrong_code"))
                .Should().ThrowAsync<AssertionFailedException>();
        }

        [Fact]
        public async Task WithErrorDescriptionAsyncShouldPassWhenDescriptionMatches()
        {
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(new Error("err_async", "Async error."));
            };

            await act.Should().ThrowAsync<ErrorException>().WithErrorDescription("Async error.");
        }

        [Fact]
        public async Task WithErrorDescriptionAsyncShouldFailWhenDescriptionDoesNotMatch()
        {
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(new Error("err_async", "Async error."));
            };

            await FluentActions.Awaiting(async () =>
                await act.Should().ThrowAsync<ErrorException>().WithErrorDescription("Wrong description."))
                .Should().ThrowAsync<AssertionFailedException>();
        }

        [Fact]
        public async Task WithErrorAsyncShouldPassWhenErrorMatches()
        {
            var error = new Error("err_async", "Async error.");
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(error);
            };

            await act.Should().ThrowAsync<ErrorException>().WithError(error);
        }

        [Fact]
        public async Task WithErrorAsyncShouldFailWhenErrorDoesNotMatch()
        {
            var error = new Error("err_async", "Async error.");
            var differentError = new Error("err_other", "Other.");
            Func<Task> act = async () =>
            {
                await Task.Yield();
                throw new ErrorException(error);
            };

            await FluentActions.Awaiting(async () =>
                await act.Should().ThrowAsync<ErrorException>().WithError(differentError))
                .Should().ThrowAsync<AssertionFailedException>();
        }
    }
}