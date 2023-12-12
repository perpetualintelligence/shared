/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace OneImlx.Shared.Infrastructure
{
    /// <summary>
    /// The generic result of a trying method. The trying method must return an error or a valid result. Both
    /// <see cref="Error"/> and <see cref="Result"/> cannot be null.
    /// </summary>
    /// <typeparam name="T">The result type.</typeparam>
    public sealed class TryResultOrError<T> where T : class
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResultOrError(Error error)
        {
            Error = error ?? throw new System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public TryResultOrError(T result)
        {
            Result = result ?? throw new System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public Error? Error { get; }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; }
    }
}
