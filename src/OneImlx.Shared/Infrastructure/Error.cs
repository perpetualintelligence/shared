/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;
using OneImlx.Shared.Attributes;

namespace OneImlx.Shared.Infrastructure
{
    /// <summary>
    /// The generic error.
    /// </summary>
    public sealed class Error
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public Error()
        {
            ErrorCode = "unknown_error";
            ErrorDescription = "An unknown error occurred.";
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments./</param>
        /// <param name="errorUri">The error URI.</param>
        /// <param name="requestId">The request id.</param>
        public Error(string errorCode, string errorDescription, object?[]? args = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(errorCode))
            {
                throw new System.ArgumentException($"'{nameof(errorCode)}' cannot be null or whitespace.", nameof(errorCode));
            }

            if (string.IsNullOrWhiteSpace(errorDescription))
            {
                throw new System.ArgumentException($"'{nameof(errorDescription)}' cannot be null or whitespace.", nameof(errorDescription));
            }

            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            Args = args;
            ErrorUri = errorUri;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments.</param>
        public Error(string errorCode, string errorDescription, params object?[] args)
        {
            if (string.IsNullOrWhiteSpace(errorCode))
            {
                throw new System.ArgumentException($"'{nameof(errorCode)}' cannot be null or whitespace.", nameof(errorCode));
            }

            if (string.IsNullOrWhiteSpace(errorDescription))
            {
                throw new System.ArgumentException($"'{nameof(errorDescription)}' cannot be null or whitespace.", nameof(errorDescription));
            }

            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            Args = args;
        }

        /// <summary>
        /// The error description format arguments.
        /// </summary>
        [JsonPropertyName("args")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object?[]? Args { get; set; }

        /// <summary>
        /// The <c>error_code</c> code.
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The <c>error_description</c>.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// The <c>error_uri</c>.
        /// </summary>
        [JsonPropertyName("error_uri")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ErrorUri { get; set; }

        /// <summary>
        /// The request identifier <c>request_id</c>.
        /// </summary>
        [JsonPropertyName("request_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequestId { get; set; }

        /// <summary>
        /// Format the <see cref="ErrorDescription"/> with the <see cref="Args"/>.
        /// </summary>
        /// <returns>Formatted error description.</returns>
        public string FormatDescription()
        {
            if (Args == null)
            {
                return ErrorDescription ?? string.Empty;
            }
            else
            {
                return string.Format(ErrorDescription, Args);
            }
        }

        /// <summary>
        /// Creates a new <see cref="Error"/> instance with formatted <see cref="ErrorDescription"/> with the <see cref="Args"/>.
        /// </summary>
        /// <returns>Formatted error instance.</returns>
        public Error FormatError()
        {
            return new Error(ErrorCode, FormatDescription(), null, ErrorUri, RequestId);
        }

        /// <summary>
        /// Set an error.
        /// </summary>
        public void SetError(string errorCode, string errorDescription, object?[]? args = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(errorCode))
            {
                throw new System.ArgumentException($"'{nameof(errorCode)}' cannot be null or whitespace.", nameof(errorCode));
            }

            if (string.IsNullOrWhiteSpace(errorDescription))
            {
                throw new System.ArgumentException($"'{nameof(errorDescription)}' cannot be null or whitespace.", nameof(errorDescription));
            }

            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            Args = args;
            ErrorUri = errorUri;
            RequestId = requestId;
        }
    }
}
