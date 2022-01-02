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
    public sealed class OneImlxTryResult<T> : OneImlxResult
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxTryResult()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public OneImlxTryResult(OneImlxError error)
        {
            SetError(error);
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public OneImlxTryResult(T result)
        {
            Result = result;
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
