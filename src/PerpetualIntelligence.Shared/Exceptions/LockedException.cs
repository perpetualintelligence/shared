/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that an object is locked.
    /// </summary>
    public class LockedException : Exception
    {
        /// <inheritdoc/>
        public LockedException() { }

        /// <inheritdoc/>
        public LockedException(string message) : base(message) { }

        /// <inheritdoc/>
        public LockedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected LockedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
