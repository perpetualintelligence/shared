/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
        /// <param name="value">The Base64 string.</param>
        /// <returns>The decoded byte array.</returns>
        /// <exception cref="InvalidOperationException">Invalid Base64 string.</exception>
        public static byte[] Decode(string value)
        {
            // Base64 sanitation.
            // -> 62nd char of encoding - (dash) to +
            // -> 63rd char of encoding _ (underscore) to /
            string s = value.Replace('-', '+').Replace('_', '/');

            // Apply the padding.
            // - https://stackoverflow.com/questions/26353710/how-to-achieve-base64-url-safe-encoding-in-c
            // - https://github.com/dotnet/aspnetcore/blob/main/src/Shared/WebEncoders/WebEncoders.cs#L389
            switch (s.Length % 4)
            {
                case 0:
                    {
                        // No pad chars in this case
                        break;
                    }
                case 2:
                    {
                        // Two padding chars ==
                        s += "=="; break;
                    }
                case 3:
                    {
                        // One padding char =
                        s += "="; break;
                    }
                default:
                    {
                        throw new InvalidOperationException($"The string '{value}' is not a valid Base64 encoded string.");
                    }
            }

            // The standard .NET Base64 converter
            return Convert.FromBase64String(s);
        }

        /// <summary>
        /// Encodes the specified byte array.
        /// </summary>
        /// <param name="value">The byte array.</param>
        /// <returns>The encoded Base64 string.</returns>
        public static string Encode(byte[] value)
        {
            // The standard .NET Base64 converter
            string s = Convert.ToBase64String(value);

            // Remove any trailing '='s
            s = s.TrimEnd('=');

            // Base64 sanitation.
            // -> 62nd char of encoding - (dash) to +
            // -> 63rd char of encoding _ (underscore) to /
            s = s.Replace('+', '-').Replace('/', '_');

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
