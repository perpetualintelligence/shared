//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

using FluentAssertions;

namespace OneImlx.Test.Extentions
{
    /// <summary>
    /// <see cref="object"/> extension methods for testing.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Asserts that the source object is not null and returns the source object for chaining.
        /// </summary>
        /// <typeparam name="T">The type of the source object.</typeparam>
        /// <param name="source">The source object to check for null.</param>
        /// <returns>The source object if it is not null.</returns>
        public static T NotNull<T>(this T? source)
        {
            source.Should().NotBeNull();
            return source;
        }
    }
}