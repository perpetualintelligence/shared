/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System;
using System.Text.RegularExpressions;

namespace PerpetualIntelligence.Protocols.Security
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
