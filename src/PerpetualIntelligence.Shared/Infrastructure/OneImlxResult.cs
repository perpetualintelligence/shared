/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Abstractions;
using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> error result.
    /// </summary>
    /// <seealso cref="OneImlxError"/>
    public class OneImlxResult : IOneImlxResult
    {
        /// <summary>
        /// The result errors.
        /// </summary>
        public OneImlxError[]? Errors
        {
            get
            {
                return _errorList?.ToArray();
            }
        }

        /// <summary>
        /// The first error, if the result represents an error.
        /// </summary>
        public OneImlxError? FirstError
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
                return _errorList?[0]?.Error;
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
                return _errorList.Any(e => !string.IsNullOrWhiteSpace(e.Error));
            }
        }

        /// <summary>
        /// Creates a new instance with the specified error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <seealso cref="NewError(string, string?, string?, string?)"/>
        public static T NewError<T>(OneImlxError error) where T : OneImlxResult
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
        /// <seealso cref="NewError{T}(OneImlxError)"/>
        public static T NewError<T>(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null) where T : OneImlxResult
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SetError(error, errorDescription, errorUri, requestId);
            return tInst;
        }

        /// <summary>
        /// Creates a new error instance synced with specified result.
        /// </summary>
        /// <param name="result">The result instance.</param>
        public static T NewError<T>(OneImlxResult result) where T : OneImlxResult
        {
            T tInst = Activator.CreateInstance<T>();
            tInst.SyncError(result);
            return tInst;
        }

        /// <summary>
        /// Creates a new success instance.
        /// </summary>
        public static T NewSuccess<T>() where T : OneImlxResult
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null)
        {
            AddError(new OneImlxError(error, errorDescription, errorUri, requestId));
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(OneImlxError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error), $"'{nameof(error)}' cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(error.Error))
            {
                throw new ArgumentException($"'{nameof(error.Error)}' cannot be null or whitespace.", nameof(error));
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
        [ToUnitTest]
        public void AppendError(OneImlxResult input)
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
        /// <seealso cref="AddError(OneImlxError)"/>
        /// <seealso cref="AddError(string, string?, string?, string?)"/>
        public void SetError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null)
        {
            SetError(new OneImlxError(error, errorDescription, errorUri, requestId));
        }

        /// <summary>
        /// Set an error on the result. This will clear all the existing errors and set the specified error.
        /// </summary>
        /// <seealso cref="AddError(OneImlxError)"/>
        /// <seealso cref="AddError(string, string?, string?, string?)"/>
        public void SetError(OneImlxError error)
        {
            // Clear all errors
            NoError();

            // Now add the specified error.
            AddError(error);
        }

        /// <summary>
        /// Syncs all the errors from the input to this instance.
        /// </summary>
        public void SyncError(OneImlxResult input)
        {
            if (input.IsError)
            {
                // Clear all on this instance
                NoError();

                // Sync errors.
                _errorList = new List<OneImlxError>(input._errorList);
            }
        }

        private List<OneImlxError>? _errorList;
    }
}
