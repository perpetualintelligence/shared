/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that a checker has failed.
    /// </summary>
    public class CheckerException : Exception
    {
        /// <inheritdoc/>
        public CheckerException() { }

        /// <inheritdoc/>
        public CheckerException(string message) : base(message) { }

        /// <inheritdoc/>
        public CheckerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected CheckerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
