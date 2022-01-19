/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception that represents an error.
    /// </summary>
    public class ErrorException : Exception
    {
        /// <inheritdoc/>
        public ErrorException(string error, string errorDescription)
        {
            Error = error;
            ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Initializes a new error exception.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments.</param>
        public ErrorException(string error, string errorDescription, params object[]? args)
        {
            Error = error;
            ErrorDescription = errorDescription;
            Args = args;
        }

        /// <summary>
        /// The error description format arguments.
        /// </summary>
        public object[]? Args { get; }

        /// <summary>
        /// The error code.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// The error description.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// The error Uri.
        /// </summary>
        public string? ErrorUri { get; set; }

        /// <inheritdoc/>
        public override string Message
        {
            get
            {
                if (Args == null)
                {
                    return ErrorDescription;
                }
                else
                {
                    return string.Format(ErrorDescription, Args);
                }
            }
        }

        /// <summary>
        /// The request id.
        /// </summary>
        public string? RequestId { get; set; }
    }
}
