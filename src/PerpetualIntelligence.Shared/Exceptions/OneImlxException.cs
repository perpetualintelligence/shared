/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
        public OneImlxException(string? error, string? errorDescription, string? errorUri, string? requestId)
        {
            Error = error;
            ErrorDescription = errorDescription;
            ErrorUri = errorUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The error code.
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// The error description.
        /// </summary>
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// The error Uri.
        /// </summary>
        public string? ErrorUri { get; set; }

        /// <inheritdoc/>
        public override string Message => $"error={Error} error_description={ErrorDescription} error_uri={ErrorUri} request_id={RequestId}";

        /// <summary>
        /// The request id.
        /// </summary>
        public string? RequestId { get; set; }

        /// <inheritdoc/>
        protected OneImlxException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
