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
    public sealed class OneImlxTryResult<T>
    {
        /// <summary>
        /// Indicates that the try has an error.
        /// </summary>
        public bool IsError
        {
            get
            {
                return TryError != null && !string.IsNullOrWhiteSpace(TryError.Error);
            }
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }

        /// <summary>
        /// The error during the try.
        /// </summary>
        public OneImlxError? TryError { get; set; }
    }
}
