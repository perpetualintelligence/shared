/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Linq;

namespace PerpetualIntelligence.Test.Services
{
    /// <summary>
    /// The unit test extension methods.
    /// </summary>
    public static class TestExtensions
    {
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
    }
}
