/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// <see cref="IEnumerable{T}"/> extension methods.
    /// </summary>
    [ToUnitTest]
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Determines if an enumerable is null or empty.
        /// </summary>
        /// <typeparam name="T">The enumerable type.</typeparam>
        /// <param name="enumerable">The enumerable to check.</param>
        /// <returns><c>true</c> if an enumerable is <c>null</c> or empty, otherwise <c>false</c>.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T>? enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }

            if (!enumerable.Any())
            {
                return true;
            }

            return false;
        }
    }
}
