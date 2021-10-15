/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception indicates that two-factor authentication is required.
    /// </summary>
    public class TwoFactorException : Exception
    {
        /// <inheritdoc/>
        public TwoFactorException() { }

        /// <inheritdoc/>
        public TwoFactorException(string message) : base(message) { }

        /// <inheritdoc/>
        public TwoFactorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc/>
        protected TwoFactorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
