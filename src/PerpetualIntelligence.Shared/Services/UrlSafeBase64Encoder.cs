/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;
using System.Text;

namespace PerpetualIntelligence.Shared.Services
{
    /// <summary>
    /// The URL safe Base64 string encoder. The encoder trims the padding character '=', replacing the characters + and
    /// with -(dash) and _(underscore), respectively.
    /// </summary>
    public static class UrlSafeBase64Encoder
    {
        /// <summary>
        /// Decodes the specified string.
        /// </summary>
        /// <param name="arg">The Base64 string.</param>
        /// <returns>The decoded byte array.</returns>
        /// <exception cref="InvalidOperationException">Invalid Base64 string.</exception>
        public static byte[] Decode(string arg)
        {
            string? s = arg;
            s = s.Replace('-', '+'); // 62nd char of encoding - (dash) to +
            s = s.Replace('_', '/'); // 63rd char of encoding _ (underscore) to /

            switch (s.Length % 4) // Pad with trailing '='s
            {
                case 0: break; // No pad chars in this case
                case 2: s += "=="; break; // Two pad chars
                case 3: s += "="; break; // One pad char
                default: throw new InvalidOperationException($"String '{arg}' is not a valid Base64 encoded string.");
            }

            return Convert.FromBase64String(s); // Standard base64 decoder
        }

        /// <summary>
        /// Encodes the specified byte array.
        /// </summary>
        /// <param name="arg">The byte array.</param>
        /// <returns>The encoded Base64 string.</returns>
        public static string Encode(byte[] arg)
        {
            string? s = Convert.ToBase64String(arg); // Standard base64 encoder

            s = s.Split('=')[0]; // Remove any trailing '='s
            s = s.Replace('+', '-'); // 62nd char of encoding  + to - (dash)
            s = s.Replace('/', '_'); // 63rd char of encoding  / to _ (underscore)

            return s;
        }

        /// <summary>
        /// Decodes the specified string and then converts the bytes to a UTF8 string.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns>The URL safe string with UTF8 encoding.</returns>
        public static string Utf8Decode(string arg)
        {
            return Encoding.UTF8.GetString(Decode(arg));
        }

        /// <summary>
        /// Encodes the specified string with <see cref="Encoding.UTF8"/> and then converts the UTF8 bytes to Url safe string.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns>The URL safe string with UTF8 encoding.</returns>
        public static string Utf8Encode(string arg)
        {
            return Encode(Encoding.UTF8.GetBytes(arg));
        }
    }
}
