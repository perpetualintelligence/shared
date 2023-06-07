/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Text.RegularExpressions;

namespace PerpetualIntelligence.Shared.Security
{
    /// <summary>
    /// Generates unique identifiers.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Generates a new <see cref="Guid"/>.
        /// </summary>
        /// <returns></returns>
        public static string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Generates a new unique long identifier. A long identifier is a <see cref="Guid"/> expressed as a string with
        /// no '-'.
        /// </summary>
        /// <returns></returns>
        public static string NewLongId()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// Generates a unique short identifier. A short identifier is a <see cref="Guid"/> expressed in a Url safe
        /// Base64 characters.
        /// </summary>
        /// <returns>A unique short identifier</returns>
        public static string NewShortId()
        {
            return Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=-]", "");
        }
    }
}
