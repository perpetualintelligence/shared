/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;
using PerpetualIntelligence.Shared.Infrastructure;
using System;
using System.Linq;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// The <see cref="ILogger{T}"/> extension methods.
    /// </summary>
    public static class ILoggerExtensions
    {
        /// <summary>
        /// Formats the message for downstream processing.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="loggingOptions">The logging options. See <see cref="OneImlxLoggingOptions"/>.</param>
        /// <param name="message">The message to format.</param>
        /// <param name="args">The format arguments.</param>
        /// <returns></returns>
        public static string Format(this ILogger logger, OneImlxLoggingOptions loggingOptions, string message, params object?[] args)
        {
            if (logger == null)
            {
                throw new InvalidOperationException("The logger is required.");
            }

            return FormatMessage(loggingOptions, message, args).Item1;
        }

        /// <summary>
        /// Logs the formated message and returns the logged message for downstream processing.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="logLevel"></param>
        /// <param name="loggingOptions"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatAndLog(this ILogger logger, LogLevel logLevel, OneImlxLoggingOptions loggingOptions, string message, params object?[] args)
        {
            // For downstream processing
            Tuple<string, object?[]>? formatted = FormatMessage(loggingOptions, message, args);

            // For actual logging
            switch (logLevel)
            {
                case LogLevel.Information:
                    {
                        logger.LogInformation(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Warning:
                    {
                        logger.LogWarning(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Error:
                    {
                        logger.LogError(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Debug:
                    {
                        logger.LogDebug(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Trace:
                    {
                        logger.LogTrace(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Critical:
                    {
                        logger.LogCritical(message, formatted.Item2);
                        break;
                    }
                default:
                    {
                        // Don't log
                        break;
                    }
            }

            return formatted.Item1;
        }

        private static Tuple<string, object?[]> FormatMessage(OneImlxLoggingOptions loggingOptions, string message, params object?[] args)
        {
            object?[] argsToUse = args;
            if (args != null)
            {
                if (!loggingOptions.RevealErrorArguments.GetValueOrDefault())
                {
                    argsToUse = Enumerable.Repeat(loggingOptions.ObscureErrorArgumentString, args.Length).ToArray();
                }
            }

            return new(string.Format(message, argsToUse), argsToUse);
        }
    }
}
