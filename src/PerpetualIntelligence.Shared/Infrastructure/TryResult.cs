/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The <c>oneimlx</c> result of a try method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class TryResult<T> : Result
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResult()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResult(Error error)
        {
            SetError(error);
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public TryResult(T result)
        {
            Result = result;
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
