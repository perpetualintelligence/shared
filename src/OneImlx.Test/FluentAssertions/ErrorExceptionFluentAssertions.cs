//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

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
            if (assertions.Which is not ErrorException exception)
            {
                throw new AssertionFailedException("Expected exception to be an ErrorException, but it was not.");
            }

            if (exception.Error.ErrorCode != expectedErrorCode)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error code to be {expectedErrorCode}{becauseMessage}, but found {exception.Error.ErrorCode}.");
            }

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
            if (assertions.Which is not ErrorException exception)
            {
                throw new AssertionFailedException("Expected exception to be an ErrorException, but it was not.");
            }

            var actualDescription = exception.Error.FormatDescription();
            if (actualDescription != expectedErrorDescription)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error description to be {expectedErrorDescription}{becauseMessage}, but found {actualDescription}.");
            }

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
            if (exceptionAssertions.Which.Error != expectedError)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error to be {expectedError}{becauseMessage}, but found {exceptionAssertions.Which.Error}.");
            }

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

            if (exceptionAssertions.Which.Error.ErrorCode != expectedErrorCode)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error code to be {expectedErrorCode}{becauseMessage}, but found {exceptionAssertions.Which.Error.ErrorCode}.");
            }

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

            var actualDescription = exceptionAssertions.Which.Error.FormatDescription();
            if (actualDescription != expectedErrorDescription)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error description to be {expectedErrorDescription}{becauseMessage}, but found {actualDescription}.");
            }

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

            if (exceptionAssertions.Which.Error != expectedError)
            {
                var becauseMessage = string.IsNullOrEmpty(because) ? "" : " because " + string.Format(because, becauseArgs);
                throw new AssertionFailedException(
                    $"Expected error to be {expectedError}{becauseMessage}, but found {exceptionAssertions.Which.Error}.");
            }

            return exceptionAssertions;
        }
    }
}