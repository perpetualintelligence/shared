/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to encode and decode text.
    /// </summary>
    public interface IEncoder
    {
        /// <summary>
        /// Decodes the text.
        /// </summary>
        /// <param name="text">Text to decode.</param>
        /// <returns>The decoded text.</returns>
        string Decode(string text);

        /// <summary>
        /// Encodes the text.
        /// </summary>
        /// <param name="text">Text to encode.</param>
        /// <returns>The encoded text.</returns>
        string Encode(string text);

        /// <summary>
        /// Encodes the bytes.
        /// </summary>
        /// <param name="bytes">Bytes to encode.</param>
        /// <returns>The encoded text.</returns>
        string Encode(byte[] bytes);
    }
}
