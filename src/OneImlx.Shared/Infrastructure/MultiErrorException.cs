/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Collections.Generic;

namespace OneImlx.Shared.Infrastructure
{
    /// <summary>
    /// The exception that represents multiple errors.
    /// </summary>
    public class MultiErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public MultiErrorException()
        {
            Errors = [];
        }

        /// <summary>
        /// Initialize a new instance with the specified errors.
        /// </summary>
        /// <param name="errors">The errors.</param>
        public MultiErrorException(IEnumerable<Error> errors)
        {
            Errors = errors ?? throw new ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initialize a new instance with the specified errors and an exception message.
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <param name="message">The consolidated exception message.</param>
        public MultiErrorException(Error[] errors, string message) : base(message)
        {
            Errors = errors ?? throw new ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// The errors in this exception.
        /// </summary>
        public IEnumerable<Error> Errors { get; }
    }
}
