/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Exceptions;
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
        /// Ensures that an action returns a result or an <see cref="Error"/> but does not throw any exception.
        /// </summary>
        /// <typeparam name="TContext">The context type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <param name="context">The action context.</param>
        /// <returns><see cref="TryResult{T}"/> instance that contains the result or an <see cref="Error"/> instance.</returns>
        public static async Task<TryResultError<TResult>> EnsureResultAsync<TContext, TResult>(ResultDelegate<TContext, TResult> action, TContext context) where TContext : class where TResult : class
        {
            try
            {
                TResult result = await action(context);
                return new TryResultError<TResult>(result);
            }
            catch (ErrorException ee)
            {
                return new TryResultError<TResult>(ee.Error);
            }
            catch (Exception ex)
            {
                Error error = new(Error.Unexpected, "The request resulted in an unexpected error. additonal_info={0}", new object?[] { ex.Message });
                return new TryResultError<TResult>(error);
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
