/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions.Execution;
using FluentAssertions.Specialized;
using OneImlx.Shared.Infrastructure;
using System;
using System.Threading.Tasks;

namespace OneImlx.Test.FluentAssertions
{
    /// <summary>
    /// Extension methods for asserting expected properties on <see cref="ErrorException"/> instances.
    /// </summary>
    public static class ErrorExceptionFluentAssertions
    {
        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> contains a specific error code.
        /// </summary>
        /// <typeparam name="TException">The type of the exception that is expected to be thrown.
        /// This must be <see cref="ErrorException"/> or a derived class.</typeparam>
        /// <param name="assertions">The Fluent Assertions object which holds the exception.</param>
        /// <param name="expectedErrorCode">The expected error code that the exception should contain.</param>
        /// <param name="because">A formatted phrase as a reason for the expected error code. This
        /// parameter can be used to provide a more detailed explanation of the assertion, improving
        /// the readability and maintainability of test code.</param>
        /// <param name="becauseArgs">An array of objects to format the <paramref name="because"/> phrase.
        /// This allows for dynamic messages in the assertion failure output, making it clearer why the
        /// assertion failed.</param>
        /// <returns>The original <see cref="ExceptionAssertions{TException}"/> object, allowing for
        /// method chaining with other assertions.</returns>
        public static ExceptionAssertions<TException> WithErrorCode<TException>(
            this ExceptionAssertions<TException> assertions,
            string expectedErrorCode,
            string because = "",
            params object[] becauseArgs)
        where TException : Exception
        {
            var exception = assertions.Which as ErrorException;

            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .WithExpectation("Expected exception with error code {0}{reason}, ", expectedErrorCode)
                .ForCondition(assertions.Which is ErrorException errorException && errorException.Error.ErrorCode == expectedErrorCode)
                .FailWith("Expected error code to be {0}{reason}, but found {1}.",
                           expectedErrorCode,
                           exception?.Error.ErrorCode);

            return assertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> contains a specific error description.
        /// </summary>
        /// <typeparam name="TException">The type of the exception that is expected to be thrown.
        /// This must be <see cref="ErrorException"/> or a derived class.</typeparam>
        /// <param name="assertions">The Fluent Assertions object which holds the exception.</param>
        /// <param name="expectedErrorDescription">The expected error code that the exception should contain.</param>
        /// <param name="because">A formatted phrase as a reason for the expected error code. This
        /// parameter can be used to provide a more detailed explanation of the assertion, improving
        /// the readability and maintainability of test code.</param>
        /// <param name="becauseArgs">An array of objects to format the <paramref name="because"/> phrase.
        /// This allows for dynamic messages in the assertion failure output, making it clearer why the
        /// assertion failed.</param>
        /// <returns>The original <see cref="ExceptionAssertions{TException}"/> object, allowing for
        /// method chaining with other assertions.</returns>
        public static ExceptionAssertions<TException> WithErrorDescription<TException>(
            this ExceptionAssertions<TException> assertions,
            string expectedErrorDescription,
            string because = "",
            params object[] becauseArgs) where TException : ErrorException
        {
            // Attempt to cast the caught exception to ErrorException to access the Error property.
            var exception = assertions.Which as ErrorException;

            // Assert that the error code of the exception matches the expected error description.
            Execute.Assertion
                .ForCondition(exception != null && exception.Error.FormatDescription() == expectedErrorDescription)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected error description to be {0}{reason}, but found {1}.",
                           expectedErrorDescription,
                           exception?.Error.FormatDescription());

            // Return the original ExceptionAssertions object to allow further assertion chaining.
            return assertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error description.
        /// This method should be used after an asynchronous operation that is expected to throw an exception.
        /// </summary>
        /// <param name="exceptionAssertions">The task operation.</param>
        /// <param name="expectedError">The expected error.</param>
        /// <param name="because">A formatted phrase explaining why the assertion should be satisfied.</param>
        /// <param name="becauseArgs">Zero or more values to use for filling in any gaps in the <paramref name="because"/> phrase.</param>
        /// <returns>A continuation object for method chaining.</returns>
        public static ExceptionAssertions<TException> WithError<TException>(
            this ExceptionAssertions<TException> exceptionAssertions,
            Error expectedError,
            string because = "",
            params object[] becauseArgs)
            where TException : ErrorException
        {
            Execute.Assertion
                .ForCondition(exceptionAssertions.Which.Error == expectedError)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected error to be {0}{reason}, but found {1}.", expectedError, exceptionAssertions.Which.Error);

            return exceptionAssertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error code.
        /// This method should be used after an asynchronous operation that is expected to throw an exception.
        /// </summary>
        /// <param name="task">The task resulting from the asynchronous operation.</param>
        /// <param name="expectedErrorCode">The expected error code.</param>
        /// <param name="because">A formatted phrase explaining why the assertion should be satisfied.</param>
        /// <param name="becauseArgs">Zero or more values to use for filling in any gaps in the <paramref name="because"/> phrase.</param>
        /// <returns>A continuation object for method chaining.</returns>
        public static async Task<ExceptionAssertions<TException>> WithErrorCode<TException>(
            this Task<ExceptionAssertions<TException>> task, string expectedErrorCode, string because = "", params object[] becauseArgs)
            where TException : ErrorException
        {
            var exceptionAssertions = await task;

            Execute.Assertion
                .ForCondition(exceptionAssertions.Which.Error.ErrorCode == expectedErrorCode)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected error code to be {0}{reason}, but found {1}.", expectedErrorCode, exceptionAssertions.Which.Error.ErrorCode);

            return exceptionAssertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error description.
        /// This method should be used after an asynchronous operation that is expected to throw an exception.
        /// </summary>
        /// <param name="task">The task resulting from the asynchronous operation.</param>
        /// <param name="expectedErrorDescription">The expected error description.</param>
        /// <param name="because">A formatted phrase explaining why the assertion should be satisfied.</param>
        /// <param name="becauseArgs">Zero or more values to use for filling in any gaps in the <paramref name="because"/> phrase.</param>
        /// <returns>A continuation object for method chaining.</returns>
        public static async Task<ExceptionAssertions<TException>> WithErrorDescription<TException>(
            this Task<ExceptionAssertions<TException>> task, string expectedErrorDescription, string because = "", params object[] becauseArgs)
            where TException : ErrorException
        {
            var exceptionAssertions = await task;

            Execute.Assertion
                .ForCondition(exceptionAssertions.Which.Error.FormatDescription() == expectedErrorDescription)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected error description to be {0}{reason}, but found {1}.", expectedErrorDescription, exceptionAssertions.Which.Error.FormatDescription());

            return exceptionAssertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error description.
        /// This method should be used after an asynchronous operation that is expected to throw an exception.
        /// </summary>
        /// <param name="task">The task resulting from the asynchronous operation.</param>
        /// <param name="expectedError">The expected error.</param>
        /// <param name="because">A formatted phrase explaining why the assertion should be satisfied.</param>
        /// <param name="becauseArgs">Zero or more values to use for filling in any gaps in the <paramref name="because"/> phrase.</param>
        /// <returns>A continuation object for method chaining.</returns>
        public static async Task<ExceptionAssertions<TException>> WithError<TException>(
            this Task<ExceptionAssertions<TException>> task, Error expectedError, string because = "", params object[] becauseArgs)
            where TException : ErrorException
        {
            var exceptionAssertions = await task;

            Execute.Assertion
                .ForCondition(exceptionAssertions.Which.Error == expectedError)
                .BecauseOf(because, becauseArgs)
                .FailWith("Expected error to be {0}{reason}, but found {1}.", expectedError, exceptionAssertions.Which.Error);

            return exceptionAssertions;
        }
    }
}