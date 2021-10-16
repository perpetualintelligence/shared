﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Security.Cryptography;

namespace PerpetualIntelligence.Protocols.Security
{
    /// <summary>
    /// Generates a HEX salt using cryptographic <see cref="RandomNumberGenerator"/>.
    /// </summary>
    [ToUnitTest]
    public static class HexSaltGenerator
    {
        /// <summary>
        /// Generates a new HEX salt of 32 bytes with no dash.
        /// </summary>
        /// <returns>The generated salt</returns>
        public static string NewSalt()
        {
            return NewSalt(length:32, strip: true);
        }

        /// <summary>
        /// Generates a new HEX salt of specified length wuth no dash.
        /// </summary>
        /// <param name="length">The salt byte length.</param>
        /// <returns>The generated salt.</returns>
        public static string NewSalt(int length)
        {
            return NewSalt(length, strip: true);
        }

        /// <summary>
        /// Generates a new HEX salt of specified length.
        /// </summary>
        /// <param name="length">The salt byte length.</param>
        /// <param name="strip"><c>true</c> to strip dash from the generated salt, otherwise <c>false</c>.</param>
        /// <returns>The generated salt.</returns>
        public static string NewSalt(int length, bool strip)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] bytes = new byte[length];
                rng.GetBytes(bytes);

                if(strip)
                {
                    return BitConverter.ToString(bytes).Replace("-", "");
                }
                else
                {
                    return BitConverter.ToString(bytes);
                }
                
            }
        }
    }
}