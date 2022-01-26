/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Abstractions;
using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic result.
    /// </summary>
    /// <seealso cref="Error"/>
    public class Result : IOneImlxResult
    {
        /// <summary>
        /// The result errors.
        /// </summary>
        public Error[]? Errors
        {
            get
            {
                return _errorList?.ToArray();
            }
        }

        /// <summary>
        /// The first error, if the result represents an error.
        /// </summary>
        public Error? FirstError
        {
            get
            {
                return _errorList?[0];
            }
        }

        /// <summary>
        /// The first error code, if the result represents an error.
        /// </summary>
        public string? FirstErrorCode
        {
            get
            {
                return _errorList?[0]?.ErrorCode;
            }
        }

        /// <summary>
        /// The first error description, if the result represents an error.
        /// </summary>
        public string? FirstErrorDescription
        {
            get
            {
                return _errorList?[0]?.ErrorDescription;
            }
        }

        /// <summary>
        /// Indicates whether the result is an error.
        /// </summary>
        public bool IsError
        {
            get
            {
                if (_errorList == null)
                {
                    return false;
                }

                // Make sure there is at-least 1 error with a valid error code
                return _errorList.Any(e => !string.IsNullOrWhiteSpace(e.ErrorCode));
            }
        }

        /// <summary>
        /// Creates a new instance with the specified error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <seealso cref="NewError(string, string?, string?, string?)"/>
        public static T NewError<T>(Error error) where T : Result
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SetError(error);
            return tInst;
        }

        /// <summary>
        /// Creates a new instance with the specified error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="errorUri">The error URI.</param>
        /// <param name="requestId">The request id.</param>
        /// <seealso cref="NewError{T}(Error)"/>
        public static T NewError<T>(string error, string errorDescription, string? errorUri = null, string? requestId = null) where T : Result
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SetError(error, errorDescription, errorUri, requestId);
            return tInst;
        }

        /// <summary>
        /// Creates a new instance with the specified <see cref="ErrorException"/>.
        /// </summary>
        /// <param name="errorException">The error exception.</param>
        /// <seealso cref="NewError{T}(Error)"/>
        public static T NewError<T>(ErrorException errorException) where T : Result
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SetError(errorException.Error);
            return tInst;
        }

        /// <summary>
        /// Creates a new error instance synced with specified result.
        /// </summary>
        /// <param name="result">The result instance.</param>
        public static T NewError<T>(Result result) where T : Result
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SyncError(result);
            return tInst;
        }

        /// <summary>
        /// Creates a new success instance.
        /// </summary>
        public static T NewSuccess<T>() where T : Result
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(string error, string errorDescription, string? errorUri = null, string? requestId = null)
        {
            AddError(new Error(error, errorDescription, null, errorUri, requestId));
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(Error error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error), $"'{nameof(error)}' cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(error.ErrorCode))
            {
                throw new ArgumentException($"'{nameof(error.ErrorCode)}' cannot be null or whitespace.", nameof(error));
            }

            if (_errorList == null)
            {
                _errorList = new();
            }

            _errorList.Add(error);
        }

        /// <summary>
        /// Appends all the errors from the input to this instance.
        /// </summary>
        [WriteUnitTest]
        public void AppendError(Result input)
        {
            if (input.IsError)
            {
                if (_errorList == null)
                {
                    _errorList = new();
                }

                _errorList.AddRange(input._errorList);
            }
        }

        /// <summary>
        /// Removes all the errors from the result.
        /// </summary>
        /// <returns></returns>
        public void NoError()
        {
            _errorList = null;
        }

        /// <summary>
        /// Set an error on the result. This will clear all the existing errors and set the specified error.
        /// </summary>
        /// <seealso cref="AddError(Error)"/>
        /// <seealso cref="AddError(string, string, string?, string?)"/>
        public void SetError(string error, string errorDescription, string? errorUri = null, string? requestId = null)
        {
            SetError(new Error(error, errorDescription, null, errorUri, requestId));
        }

        /// <summary>
        /// Set an error on the result. This will clear all the existing errors and set the specified error.
        /// </summary>
        /// <seealso cref="AddError(Error)"/>
        /// <seealso cref="AddError(string, string?, string?, string?)"/>
        public void SetError(Error error)
        {
            // Clear all errors
            NoError();

            // Now add the specified error.
            AddError(error);
        }

        /// <summary>
        /// Syncs all the errors from the input to this instance.
        /// </summary>
        public void SyncError(Result input)
        {
            if (input.IsError)
            {
                // Clear all on this instance
                NoError();

                // Sync errors.
                _errorList = new List<Error>(input._errorList);
            }
        }

        private List<Error>? _errorList;
    }
}
