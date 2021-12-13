/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The generic <c>oneimlx</c> exception.
    /// </summary>
    public class OneImlxException : Exception
    {
        /// <inheritdoc/>
        public OneImlxException()
        { }

        /// <inheritdoc/>
        public OneImlxException(string message) : base(message) { }

        /// <inheritdoc/>
        public OneImlxException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected OneImlxException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
