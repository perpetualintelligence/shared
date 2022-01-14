/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System.Linq;

namespace PerpetualIntelligence.Shared.Services
{
    /// <summary>
    /// Provides methods to format error.
    /// </summary>
    public static class ErrorFormatter
    {
        /// <summary>
        /// Formats the error message for downstream processing.
        /// </summary>
        /// <param name="loggingOptions">The logging options. See <see cref="OneImlxLoggingOptions"/>.</param>
        /// <param name="message">The message to format.</param>
        /// <param name="args">The format arguments.</param>
        /// <returns>The formatted error message.</returns>
        public static string Format(OneImlxLoggingOptions loggingOptions, string message, params object[] args)
        {
            return string.Format(message, Obscure(loggingOptions, args));
        }

        /// <summary>
        /// Obscures the arguments based on <see cref="OneImlxLoggingOptions"/>.
        /// </summary>
        /// <param name="loggingOptions">The logging options.</param>
        /// <param name="args">The arguments to obscure.</param>
        /// <returns>The obscured arguments.</returns>
        public static object[]? Obscure(OneImlxLoggingOptions loggingOptions, params object[]? args)
        {
            object[]? argsToUse = args;
            if (args != null)
            {
                if (!loggingOptions.RevealErrorArguments.GetValueOrDefault())
                {
                    argsToUse = Enumerable.Repeat(loggingOptions.ObscureErrorArgumentString, args.Length).ToArray();
                }
            }
            return argsToUse;
        }
    }
}
