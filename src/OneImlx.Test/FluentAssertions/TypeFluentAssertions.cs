/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Types;
using System;
using System.Linq;
using System.Reflection;

namespace OneImlx.Test.FluentAssertions
{
    /// <summary>
    /// The fluent assertion extension methods for <see cref="Type"/>.
    /// </summary>
    public static class TypeFluentAssertions
    {
        /// <summary>
        /// Asserts that the specified type has the defined number of constants.
        /// </summary>
        /// <param name="assertions">Fluent Assertions wrapper for the type.</param>
        /// <param name="expectedCount">The expected number of constants.</param>
        /// <returns>An AndConstraint object for method chaining.</returns>
        public static AndConstraint<TypeAssertions> HaveConstantCount(this TypeAssertions assertions, int expectedCount)
        {
            var type = assertions.Subject ?? throw new ArgumentNullException(nameof(assertions.Subject), "The asserted type is null.");

            var constants = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                                .Where(fi => fi.IsLiteral && !fi.IsInitOnly);

            Execute.Assertion
                .ForCondition(constants.Count() == expectedCount)
                .FailWith($"Expected type '{type.FullName}' to define exactly {expectedCount} constants, but found {constants.Count()}.");

            return new AndConstraint<TypeAssertions>(assertions);
        }
    }
}