/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Exceptions;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Defines the commonly used modes.
    /// </summary>
    /// <seealso cref="ModeIdentity"/>
    public static class Modes
    {
        /// <summary>
        /// Returns all the supported modes.
        /// </summary>
        /// <returns>Array of all the supported modes.</returns>
        public static string[] All()
        {
            return new string[] { Neutral, Test, Stage, Live };
        }

        /// <summary>
        /// Determines if the specified mode is <see cref="Test"/> or <see cref="Live"/>.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns><c>true</c> if the specified mode is <see cref="Test"/> or <see cref="Live"/>, otherwise <c>false</c>.</returns>
        public static bool IsTestOrLive(string mode)
        {
            if (string.IsNullOrEmpty(mode))
            {
                return false;
            }

            return mode.Equals(Test) || mode.Equals(Live);
        }

        /// <summary>
        /// Determines if the mode is valid.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns><c>true</c> if the specified mode is valid, otherwise <c>false</c>.</returns>
        public static bool IsValid(string mode)
        {
            if (string.IsNullOrEmpty(mode))
            {
                return false;
            }

            return mode.Equals(Test) || mode.Equals(Live) || mode.Equals(Neutral) || mode.Equals(Stage);
        }

        /// <summary>
        /// Throws an exception if the specified mode is not valid.
        /// </summary>
        /// <param name="mode">Environment to validate.</param>
        public static void ThrowIfInvalid(string mode)
        {
            if (!IsValid(mode))
            {
                throw new ErrorException(Error.InvalidRequest, $"Mode '{mode}' is not valid.");
            }
        }

        /// <summary>
        /// Live or production mode.
        /// </summary>
        public const string Live = "urn:oneimlx:mode:live";

        /// <summary>
        /// Neutral or no mode.
        /// </summary>
        public const string Neutral = "urn:oneimlx:mode:neutral";

        /// <summary>
        /// Staging or pre-production mode.
        /// </summary>
        public const string Stage = "urn:oneimlx:mode:stage";

        /// <summary>
        /// Test or sandbox mode.
        /// </summary>
        public const string Test = "urn:oneimlx:mode:test";
    }
}
