/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
        public NotUniqueException()
        { }

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
