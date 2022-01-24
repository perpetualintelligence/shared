/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;
using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Exceptions;
using PerpetualIntelligence.Shared.Extensions;
using PerpetualIntelligence.Shared.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Services
{
    /// <summary>
    /// Provides methods to format error.
    /// </summary>
    [WriteUnitTest]
    public static class Formatter
    {
        /// <summary>
        /// Ensures that the action returns a <see cref="Result"/>.
        /// </summary>
        /// <typeparam name="TContext">The context type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <param name="context">The action context.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="options">The configuration option.</param>
        /// <returns></returns>
        public static Task<TResult> EnsureResultAsync<TContext, TResult>(ResultDelegate<TContext, TResult> action, TContext context, ILogger logger, LoggingOptions options) where TContext : class where TResult : Result
        {
            try
            {
                return action(context);
            }
            catch (ErrorException ee)
            {
                string errorDesc = logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Error, options, ee.ErrorDescription, ee.Args);
                return Task.FromResult(Result.NewError<TResult>(ee.Error, errorDesc));
            }
            catch (Exception ex)
            {
                string errorDesc = logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Error, options, "The request resulted in an unexpected error. additonal_info={0}", ex.Message);
                return Task.FromResult(Result.NewError<TResult>("unexpected_error", errorDesc));
            }
        }

        /// <summary>
        /// Formats the error message for downstream processing.
        /// </summary>
        /// <param name="loggingOptions">The logging options. See <see cref="LoggingOptions"/>.</param>
        /// <param name="message">The message to format.</param>
        /// <param name="args">The format arguments.</param>
        /// <returns>The formatted error message.</returns>
        public static string Format(LoggingOptions loggingOptions, string message, params object?[] args)
        {
            return string.Format(message, Obscure(loggingOptions, args));
        }

        /// <summary>
        /// Obscures the arguments based on <see cref="LoggingOptions"/>.
        /// </summary>
        /// <param name="loggingOptions">The logging options.</param>
        /// <param name="args">The arguments to obscure.</param>
        /// <returns>The obscured arguments.</returns>
        public static object?[] Obscure(LoggingOptions loggingOptions, params object?[] args)
        {
            object?[] argsToUse = args;
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
