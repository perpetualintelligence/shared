/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System;

namespace PerpetualIntelligence.Shared.Exceptions
{
    /// <summary>
    /// The exception that represents an error.
    /// </summary>
    public class ErrorException : Exception
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public ErrorException()
        {
            Error = new Error(Error.Unexpected, "");
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error">The error.</param>
        public ErrorException(Error error)
        {
            Error = error ?? throw new ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorException(string message) : base(message)
        {
            Error = new Error(Error.Unexpected, "");
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        public ErrorException(string error, string errorDescription)
        {
            Error = new Error(error, errorDescription);
        }

        /// <summary>
        /// Initializes a new error exception.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments.</param>
        public ErrorException(string error, string errorDescription, params object?[] args)
        {
            Error = new Error(error, errorDescription, args);
        }

        /// <summary>
        /// The error.
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        /// The exception message.
        /// </summary>
        public override string Message
        {
            get
            {
                // FOMAC: we need to make sure ErrorDescription is never null
                if (Error.ErrorDescription == null)
                {
                    return base.Message;
                }
                else
                {
                    return Error.FormatDescription();
                }
            }
        }
    }
}
