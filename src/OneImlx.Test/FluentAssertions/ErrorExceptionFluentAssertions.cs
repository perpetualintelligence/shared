/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions.Execution;
using FluentAssertions.Specialized;
using OneImlx.Shared.Infrastructure;
using System.Threading.Tasks;

namespace OneImlx.Test.FluentAssertions
{
    /// <summary>
    /// Extension methods for asserting expected properties on <see cref="ErrorException"/> instances.
    /// </summary>
    public static class ErrorExceptionFLuentAssertions
    {
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