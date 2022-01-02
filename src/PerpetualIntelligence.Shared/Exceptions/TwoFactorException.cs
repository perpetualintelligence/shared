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
    /// The exception indicates that two-factor authentication is required.
    /// </summary>
    public class TwoFactorException : Exception
    {
        /// <inheritdoc/>
        public TwoFactorException()
        { }

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
