/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Collections.Generic;

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
        public static string JoinSpace(this IEnumerable<string> list)
        {
            if (list == null)
            {
                return string.Empty;
            }

            return string.Join(" ", list).Trim();
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
                result = result.Substring(trim.Length);
            }

            return result;
        }
    }
}
