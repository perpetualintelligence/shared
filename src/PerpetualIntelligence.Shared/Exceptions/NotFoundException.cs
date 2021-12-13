/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that an object or an entity does not exist.
    /// </summary>
    public class NotFoundException : Exception
    {
        /// <inheritdoc/>
        public NotFoundException() { }

        /// <inheritdoc/>
        public NotFoundException(string message) : base(message) { }

        /// <inheritdoc/>
        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected NotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
