/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that a checker has failed.
    /// </summary>
    public class CheckerException : Exception
    {
        /// <inheritdoc/>
        public CheckerException(Result result)
        {
            Result = result;
        }

        /// <inheritdoc/>
        public CheckerException()
        { }

        /// <inheritdoc/>
        public CheckerException(string message) : base(message) { }

        /// <inheritdoc/>
        public CheckerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// The checker result.
        /// </summary>
        public Result? Result { get; }

        /// <inheritdoc/>
        protected CheckerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
