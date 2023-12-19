/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions.Execution;
using FluentAssertions.Specialized;
using OneImlx.Shared.Infrastructure;

namespace OneImlx.Test.FluentAssertions
{
    /// <summary>
    /// Extension methods for asserting expected properties on <see cref="ErrorException"/> instances.
    /// </summary>
    public static class ErrorExceptionAssertionsExtensions
    {
        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error.
        /// </summary>
        /// <param name="assertions">The wrapped <see cref="ExceptionAssertions{T}"/>.</param>
        /// <param name="expectedError">The expected error to assert.</param>
        /// <returns>The same <see cref="ExceptionAssertions{T}"/> to support fluent assertions chaining.</returns>
        public static ExceptionAssertions<ErrorException> WithError(this ExceptionAssertions<ErrorException> assertions, Error expectedError)
        {
            Execute.Assertion
                .ForCondition(assertions.Which.Error == expectedError)
                .FailWith("Expected error {0}, but found {1}.", expectedError, assertions.Which.Error.ErrorCode);

            return assertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error code.
        /// </summary>
        /// <param name="assertions">The wrapped <see cref="ExceptionAssertions{T}"/>.</param>
        /// <param name="expectedErrorCode">The expected error code to assert.</param>
        /// <returns>The same <see cref="ExceptionAssertions{T}"/> to support fluent assertions chaining.</returns>
        public static ExceptionAssertions<ErrorException> WithErrorCode(this ExceptionAssertions<ErrorException> assertions, string expectedErrorCode)
        {
            Execute.Assertion
                .ForCondition(assertions.Which.Error.ErrorCode == expectedErrorCode)
                .FailWith("Expected error code {0}, but found {1}.", expectedErrorCode, assertions.Which.Error.ErrorCode);

            return assertions;
        }

        /// <summary>
        /// Asserts that a thrown <see cref="ErrorException"/> has a specific error description.
        /// </summary>
        /// <param name="assertions">The wrapped <see cref="ExceptionAssertions{T}"/>.</param>
        /// <param name="expectedErrorDescription">The expected error description to assert.</param>
        /// <returns>The same <see cref="ExceptionAssertions{T}"/> to support fluent assertions chaining.</returns>
        public static ExceptionAssertions<ErrorException> WithErrorDescription(this ExceptionAssertions<ErrorException> assertions, string expectedErrorDescription)
        {
            Execute.Assertion
                .ForCondition(assertions.Which.Error.ErrorDescription == expectedErrorDescription)
                .FailWith("Expected error description {0}, but found {1}.", expectedErrorDescription, assertions.Which.Error.ErrorDescription);

            return assertions;
        }
    }
}