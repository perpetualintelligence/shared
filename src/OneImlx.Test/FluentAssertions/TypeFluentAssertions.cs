/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Types;

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
        public static AndConstraint<TypeAssertions> HaveConstantCount(
            this TypeAssertions assertions,
            int expectedCount)
        {
            var type = assertions.Subject ?? throw new ArgumentNullException(nameof(assertions), "The asserted type is null.");

            var constants = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                                .Where(fi => fi.IsLiteral && !fi.IsInitOnly);

            Execute.Assertion
                .ForCondition(constants.Count() == expectedCount)
                .FailWith($"Expected type '{type.FullName}' to define exactly {expectedCount} constants, but found {constants.Count()}.");

            return new AndConstraint<TypeAssertions>(assertions);
        }

        /// <summary>
        /// Asserts that a specified property of a type is decorated with the <see cref="JsonPropertyNameAttribute"/>
        /// having a specific name.
        /// </summary>
        /// <param name="typeAssertions">The TypeAssertions instance on which this method extends.</param>
        /// <param name="propertyName">The name of the property to check.</param>
        /// <param name="jsonPropertyName">The expected name value of the JsonPropertyNameAttribute.</param>
        /// <returns>An AndConstraint for continuing the assertion chain.</returns>
        public static AndConstraint<TypeAssertions> HaveJsonProperty(
            this TypeAssertions typeAssertions,
            string propertyName,
            string jsonPropertyName)
        {
            // Use reflection to get the specified property from the type.
            PropertyInfo propertyInfo = typeAssertions.Subject.GetProperty(propertyName);

            // Try to get the JsonPropertyNameAttribute from the property.
            JsonPropertyNameAttribute? jsonAttribute = propertyInfo?.GetCustomAttribute<JsonPropertyNameAttribute>();

            // Assert that the property exists, and its JsonPropertyNameAttribute has the expected name.
            Execute.Assertion
                .ForCondition(propertyInfo != null)
                    .FailWith("Expected type {0} to have a property named {1}, but no such property was found.",
                        typeAssertions.Subject, propertyName)
                .Then
                .ForCondition(jsonAttribute != null && jsonAttribute.Name == jsonPropertyName)
                    .FailWith("Expected property {0} on type {1} to be decorated with JsonPropertyNameAttribute with a name of '{2}', but found '{3}'.",
                        propertyName, typeAssertions.Subject, jsonPropertyName, jsonAttribute?.Name ?? "null");

            // Return an AndConstraint to allow for further assertions.
            return new AndConstraint<TypeAssertions>(typeAssertions);
        }

        /// <summary>
        /// Asserts that the specified type has the defined number of properties.
        /// </summary>
        /// <param name="assertions">Fluent Assertions wrapper for the type.</param>
        /// <param name="expectedCount">The expected number of properties.</param>
        /// <returns>An AndConstraint object for method chaining.</returns>
        public static AndConstraint<TypeAssertions> HavePropertyCount(
            this TypeAssertions assertions,
            int expectedCount)
        {
            var type = assertions.Subject ?? throw new ArgumentNullException(nameof(assertions), "The asserted type is null.");

            // Retrieves both static and instance public properties.
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            Execute.Assertion
                .ForCondition(properties.Length == expectedCount)
                .FailWith($"Expected type '{type.FullName}' to define exactly {expectedCount} public properties (both static and instance), but found {properties.Length}.");

            return new AndConstraint<TypeAssertions>(assertions);
        }

        /// <summary>
        /// Asserts that all public properties are either decorated with <see cref="JsonPropertyNameAttribute"/> with a
        /// correct name, or with <see cref="JsonIgnoreAttribute"/>.
        /// </summary>
        /// <param name="typeAssertions">The TypeAssertions instance on which this method extends.</param>
        /// <param name="because">The reason why the assertion is needed.</param>
        /// <param name="becauseArgs">Optional values for formatting the reason message.</param>
        /// <returns>An AndConstraint for continuing the assertion chain.</returns>
        public static AndConstraint<TypeAssertions> HaveSnakeCaseJsonNames(
            this TypeAssertions typeAssertions,
            string because = "",
            params object[] becauseArgs)
        {
            var type = typeAssertions.Subject ?? throw new ArgumentNullException(nameof(typeAssertions), "The asserted type is null.");

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var jsonPropertyName = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                var jsonIgnore = property.GetCustomAttribute<JsonIgnoreAttribute>();

                if (jsonPropertyName != null)
                {
                    var expectedJsonName = ToExpectedSnakeCase(property.Name);

                    Execute.Assertion
                        .ForCondition(jsonPropertyName.Name == expectedJsonName)
                        .BecauseOf(because, becauseArgs)
                        .FailWith("Expected property \"{0}\" to have JsonPropertyName \"{1}\", but found \"{2}\".",
                            property.Name, expectedJsonName, jsonPropertyName.Name);
                }
                else
                {
                    if (jsonIgnore == null)
                    {
                        Execute.Assertion
                            .FailWith("Expected property \"{0}\" to be decorated with either [JsonPropertyName] or [JsonIgnore], but no attribute was found.", property.Name);
                    }

                    // else: Property is [JsonIgnore], so no validation needed.
                }
            }

            return new AndConstraint<TypeAssertions>(typeAssertions);
        }

        /// <summary>
        /// Converts a PascalCase property name to the expected snake_case JSON name.
        /// </summary>
        /// <param name="propertyName">The property name in PascalCase.</param>
        /// <returns>The expected snake_case JSON name.</returns>
        private static string ToExpectedSnakeCase(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                return string.Empty;

            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < propertyName.Length; i++)
            {
                var c = propertyName[i];
                if (char.IsUpper(c))
                {
                    if (i > 0)
                    {
                        builder.Append('_');
                    }

                    builder.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
    }
}
