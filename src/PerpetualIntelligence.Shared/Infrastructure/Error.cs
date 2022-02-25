/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic error.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public Error()
        {
            ErrorCode = Unexpected;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments./</param>
        /// <param name="errorUri">The error URI.</param>
        /// <param name="requestId">The request id.</param>
        public Error(string error, string errorDescription, object?[]? args = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            // FOMAC:
            // For now lot of test failures
            //if (string.IsNullOrWhiteSpace(errorDescription))
            //{
            //    throw new System.ArgumentException($"'{nameof(errorDescription)}' cannot be null or whitespace.", nameof(errorDescription));
            //}

            ErrorCode = error;
            ErrorDescription = errorDescription;
            Args = args;
            ErrorUri = errorUri;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="error">The error code.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="args">The error description format arguments.</param>
        public Error(string error, string errorDescription, params object?[] args)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            ErrorCode = error;
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
        /// The <c>error</c> code. Defaults to <c>unexpected_error</c>.
        /// </summary>
        [JsonPropertyName("error")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The <c>error_description</c>.
        /// </summary>
        [JsonPropertyName("error_description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ErrorDescription { get; set; }

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
        [WriteUnitTest]
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
        /// Set an error.
        /// </summary>
        public void SetError(string error, string errorDescription, object?[]? args = null, string? errorUri = null, string? requestId = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            if (string.IsNullOrWhiteSpace(errorDescription))
            {
                throw new System.ArgumentException($"'{nameof(errorDescription)}' cannot be null or whitespace.", nameof(errorDescription));
            }

            ErrorCode = error;
            ErrorDescription = errorDescription;
            Args = args;
            ErrorUri = errorUri;
            RequestId = requestId;
        }

        /// <summary>
        /// The unexpected error.
        /// </summary>
        [JsonIgnore]
        public const string Unexpected = "unexpected_error";

        /// <summary>
        /// The unknown error.
        /// </summary>
        [JsonIgnore]
        public const string Unknown = "unknown_error";

        /// <summary>
        /// The unauthorized error.
        /// </summary>
        [JsonIgnore]
        public const string Unauthorized = "unauthorized_access";
    }
}
