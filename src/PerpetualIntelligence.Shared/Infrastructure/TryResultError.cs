/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic result of a try method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class TryResultError<T> where T : class
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResultError(Error error)
        {
            Error = error ?? throw new System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public TryResultError(T result)
        {
            Result = result ?? throw new System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public Error? Error { get; set; }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
