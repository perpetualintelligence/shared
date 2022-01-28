/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic result of a trying method. The trying method must return errors or a valid result. Both
    /// <see cref="Result.Errors"/> and <see cref="Result"/> cannot be null.
    /// </summary>
    /// <typeparam name="T">The result type.</typeparam>
    public sealed class TryResultOrErrors<T> : Result where T : class
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResultOrErrors()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResultOrErrors(Error error)
        {
            if (error is null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            SetError(error);
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public TryResultOrErrors(T result)
        {
            Result = result ?? throw new System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
