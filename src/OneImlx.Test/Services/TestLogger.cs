/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.Extensions.Logging;

namespace OneImlx.Test.Services
{
    /// <summary>
    /// The test logger provider.
    /// </summary>
    public static class TestLogger
    {
        /// <summary>
        /// Creates a new <see cref="ILogger{TCategoryName}"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ILogger<T> Create<T>()
        {
            return new LoggerFactory().CreateLogger<T>();
        }
    }
}
