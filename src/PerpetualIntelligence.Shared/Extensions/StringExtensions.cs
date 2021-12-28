/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// <see cref="string"/> extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines if the string is not null or white space.
        /// </summary>
        /// <param name="self">The string to check.</param>
        /// <returns><c>true</c> if string is not null or white space, otherwise <c>false</c>.</returns>
        public static bool IsNotNullOrWhiteSpace(this string? self)
        {
            return !string.IsNullOrWhiteSpace(self);
        }

        /// <summary>
        /// Determines if the string is null or empty.
        /// </summary>
        /// <param name="self">The string to check.</param>
        /// <returns><c>true</c> if string is null or empty, otherwise <c>false</c>.</returns>
        public static bool IsNullOrEmpty(this string? self)
        {
            return string.IsNullOrEmpty(self);
        }

        /// <summary>
        /// Determines if the string is null or white space.
        /// </summary>
        /// <param name="self">The string to check.</param>
        /// <returns><c>true</c> if string is null or empty, otherwise <c>false</c>.</returns>
        public static bool IsNullOrWhiteSpace(this string? self)
        {
            return string.IsNullOrWhiteSpace(self);
        }

        /// <summary>
        /// Joins the string collection with a space separator.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string JoinBySpace(this IEnumerable<string> list)
        {
            if (list == null)
            {
                return string.Empty;
            }

            return string.Join(" ", list).Trim();
        }

        /// <summary>
        /// Repeats the string for the specified times.
        /// </summary>
        /// <param name="value">The value to repeat.</param>
        /// <param name="count">The count.</param>
        /// <returns>New repeated string.</returns>
        public static string Repeat(this string value, int count)
        {
            var parts = new string[count];
            return parts.Aggregate((x, y) => (x ?? value) + value);
        }

        /// <summary>
        /// Removes the leading occurrence of a string.
        /// </summary>
        /// <param name="self">The string to trim.</param>
        /// <param name="trim">The string to trim from start.</param>
        public static string TrimStart(this string self, string? trim)
        {
            if (string.IsNullOrEmpty(trim))
            {
                return self;
            }

            string result = self;
            while (result.StartsWith(trim, System.StringComparison.Ordinal))
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                result = result.Substring(trim.Length);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }

            return result;
        }
    }
}
