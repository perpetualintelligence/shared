/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
