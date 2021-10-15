/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that the identity of an object or an entity is not unique. In other words, multiple
    /// objects or entities exist for the same identity.
    /// </summary>
    public class NotUniqueException : Exception
    {
        /// <inheritdoc/>
        public NotUniqueException() { }

        /// <inheritdoc/>
        public NotUniqueException(string message) : base(message) { }

        /// <inheritdoc/>
        public NotUniqueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected NotUniqueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
