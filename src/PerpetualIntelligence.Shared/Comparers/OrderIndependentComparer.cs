/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Extensions;
using System;
using System.Collections.Generic;

namespace PerpetualIntelligence.Shared.Comparers
{
    /// <summary>
    /// The default order independent comparer makes the order of values irrelevant. E.g., the "code id_token token" is
    /// equivalent to "code token id_token".
    /// </summary>
    public class OrderIndependentComparer : IEqualityComparer<string?>
    {
        /// <summary>
        /// Determines whether the specified values are equal.
        /// </summary>
        /// <param name="x">The string to compare to <c>y</c>.</param>
        /// <param name="y">The string to compare to <c>x</c>.</param>
        /// <returns><c>true</c> if the specified values are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(string? x, string? y)
        {
            if (x == y)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            if (x.Length != y.Length)
            {
                return false;
            }

            HashSet<string> xSet = new(x.SplitBySpace(), StringComparer.Ordinal);
            HashSet<string> ySet = new(y.SplitBySpace(), StringComparer.Ordinal);
            return xSet.SetEquals(ySet);
        }

        /// <summary>
        /// Returns a hash code for the value.
        /// </summary>
        /// <param name="value">The value for which a hash code is to be returned.</param>
        /// <returns>
        /// A hash code for the value, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public int GetHashCode(string? value)
        {
            if (value == null)
            {
                return 0;
            }

            HashSet<string> valueSet = new(value.SplitBySpace(), StringComparer.Ordinal);
            if (valueSet.Count == 1)
            {
                return value.GetHashCode();
            }

            return valueSet.GetHashCode();
        }
    }
}
