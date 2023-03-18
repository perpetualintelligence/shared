/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
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
        /// Returns an empty string if this string is null.
        /// </summary>
        /// <param name="self">The string to check.</param>
        /// <returns><c>true</c> if string is not null or white space, otherwise <c>false</c>.</returns>
        public static string EmptyIfNull(this string? self)
        {
            return self ?? string.Empty;
        }

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
        /// Joins the string collection with a <see cref="Environment.NewLine"/> separator.
        /// </summary>
        /// <param name="list">A collection of string to join.</param>
        /// <returns>A joined string.</returns>
        public static string JoinByNewline(this IEnumerable<string>? list)
        {
            if (list == null)
            {
                return string.Empty;
            }

            return string.Join(Environment.NewLine, list);
        }

        /// <summary>
        /// Joins the string collection with a space separator.
        /// </summary>
        /// <param name="list">A collection of string to join.</param>
        /// <returns>A joined string.</returns>
        public static string JoinBySpace(this IEnumerable<string>? list)
        {
            if (list == null)
            {
                return string.Empty;
            }

            return string.Join(" ", list);
        }

        /// <summary>
        /// Returns a non null string.
        /// </summary>
        /// <param name="self">The string to check.</param>
        /// <returns><c>true</c> if string is not null or white space, otherwise <c>false</c>.</returns>
        public static string NotNull(this string? self)
        {
            return self!;
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
        /// Splits the string with a <see cref="Environment.NewLine"/>
        /// </summary>
        /// <param name="self">The string to split.</param>
        /// <returns>An array of string split by newline separator.</returns>
        public static string[] SplitByNewline(this string? self)
        {
            if (self == null)
            {
                return Array.Empty<string>();
            }

            return self.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }

        /// <summary>
        /// Splits the string with a space separator.
        /// </summary>
        /// <param name="self">The string to split.</param>
        /// <returns>An array of string split by space separator.</returns>
        public static string[] SplitBySpace(this string? self)
        {
            if (self == null)
            {
                return Array.Empty<string>();
            }

            return self.Split(new[] { ' ' }, StringSplitOptions.None);
        }

        /// <summary>
        /// Removes the trailing occurrence of a string recursively.
        /// </summary>
        /// <param name="self">The string to trim.</param>
        /// <param name="trim">The string to trim from start.</param>
        /// <param name="stringComparison">The string comparison.</param>
        public static string TrimEnd(this string self, string? trim, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(trim))
            {
                return self;
            }

            string result = self;
            while (result.EndsWith(trim, stringComparison))
            {
                result = result.Remove(result.LastIndexOf(trim, stringComparison));
            }

            return result;
        }

        /// <summary>
        /// Removes the leading occurrence of a string recursively.
        /// </summary>
        /// <param name="self">The string to trim.</param>
        /// <param name="trim">The string to trim from start.</param>
        /// <param name="stringComparison">The string comparison.</param>
        public static string TrimStart(this string self, string? trim, StringComparison stringComparison)
        {
            if (string.IsNullOrEmpty(trim))
            {
                return self;
            }

            string result = self;
            while (result.StartsWith(trim, stringComparison))
            {
#if NETSTANDARD2_1_OR_GREATER
                result = result[trim.Length..];
#else
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                result = result.Substring(trim.Length);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#endif
            }

            return result;
        }
    }
}
