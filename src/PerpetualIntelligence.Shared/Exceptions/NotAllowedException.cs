/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that an operation is not allowed.
    /// </summary>
    public class NotAllowedException : Exception
    {
        /// <inheritdoc/>
        public NotAllowedException() { }

        /// <inheritdoc/>
        public NotAllowedException(string message) : base(message) { }

        /// <inheritdoc/>
        public NotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected NotAllowedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
