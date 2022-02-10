/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// <see cref="IEnumerable{T}"/> extension methods.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Determines whether the sequence contains duplicate elements.
        /// </summary>
        /// <typeparam name="T">The type of element.</typeparam>
        /// <typeparam name="TProp">The selector predicate.</typeparam>
        /// <param name="list">The sequence to check.</param>
        /// <param name="selector">The selector predicate.</param>
        [WriteUnitTest]
        public static bool HasDuplicates<T, TProp>(this IEnumerable<T> list, Func<T, TProp> selector)
        {
            var d = new HashSet<TProp>();
            foreach (var t in list)
            {
                if (!d.Add(selector(t)))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether the sequence is null or empty.
        /// </summary>
        /// <param name="list">The sequence to check.</param>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T?>? list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }
    }
}
