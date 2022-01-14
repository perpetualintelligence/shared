/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Shared.Services;
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
        /// <param name="formatArgs">The error description format arguments.</param>
        public ErrorException(string error, string errorDescription, params object[]? formatArgs)
        {
            Error = error;
            ErrorDescription = errorDescription;
            FormatArgs = formatArgs;
        }

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

        /// <summary>
        /// The error description format arguments.
        /// </summary>
        public object[]? FormatArgs { get; }

        /// <inheritdoc/>
        public override string Message
        {
            get
            {
                if (FormatArgs == null)
                {
                    return ErrorDescription;
                }
                else
                {
                    return string.Format(ErrorDescription, FormatArgs);
                }
            }
        }

        /// <summary>
        /// The request id.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Formats the <see cref="ErrorDescription"/> based on the specified <see cref="OneImlxLoggingOptions"/>.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public string Format(OneImlxLoggingOptions options)
        {
            ErrorFormatter.Format(options, ErrorDescription, FormatArgs);
        }
    }
}
