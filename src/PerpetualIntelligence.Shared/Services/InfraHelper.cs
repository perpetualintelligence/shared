/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Exceptions;
using PerpetualIntelligence.Shared.Extensions;
using PerpetualIntelligence.Shared.Infrastructure;
using System;
using System.IO;

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Services
{
    /// <summary>
    /// Provides low level infrastructure helper methods shared across application stack.
    /// </summary>
    public static class InfraHelper
    {
        /// <summary>
        /// Ensures an action returns a result or an <see cref="Error"/> but does not throw any exception.
        /// </summary>
        /// <typeparam name="TContext">The context type.</typeparam>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <param name="context">The action context.</param>
        /// <returns>
        /// <see cref="TryResultOrError{T}"/> instance that contains the result or an <see cref="Error"/> instance.
        /// </returns>
        public static async Task<TryResultOrError<TResult>> EnsureResultAsync<TContext, TResult>(ResultDelegate<TContext, TResult> action, TContext context) where TContext : class where TResult : class
        {
            try
            {
                TResult result = await action(context);
                return new TryResultOrError<TResult>(result);
            }
            catch (ErrorException ee)
            {
                return new TryResultOrError<TResult>(ee.Error);
            }
            catch (Exception ex)
            {
                Error error = new("unexpected_error", "The request resulted in an unexpected error. info={0}", new object?[] { ex.Message });
                return new TryResultOrError<TResult>(error);
            }
        }

        /// <summary>
        /// Gets the parent directory of a specified path or sub-directory.
        /// </summary>
        /// <param name="path">Path or sub-directory.</param>
        /// <returns>
        /// The parent directory returned by <see cref="DirectoryInfo.Parent"/> property or <see langword="null"/> if
        /// file path denotes a root.
        /// </returns>
        /// <exception cref="ArgumentException">Path is null or empty.</exception>
        /// <seealso cref="Directory.GetParent(string)"/>
        public static string? GetParent(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Invalid path.", nameof(path));
            }

            if (!Path.IsPathRooted(path))
            {
                // FOMAC: Take string comparison ?
                // - Full name return the current directory for relative paths.
                string parentPath = Directory.GetParent(path).FullName.TrimStart(Directory.GetCurrentDirectory(), StringComparison.Ordinal);
                if (!path.StartsWith("" + Path.DirectorySeparatorChar, StringComparison.Ordinal))
                {
                    return parentPath.TrimStart(Path.DirectorySeparatorChar);
                }
            }

            return Directory.GetParent(path).FullName;
        }

        /// <summary>
        /// Gets the parent directory at the specified level of a specified path or sub-directory.
        /// </summary>
        /// <param name="path">Path or sub-directory.</param>
        /// <param name="level">The levels to go up.</param>
        /// <returns>
        /// The parent directory returned by <see cref="DirectoryInfo.Parent"/> for specified level or
        /// <see langword="null"/> if file path denotes a root.
        /// </returns>
        /// <exception cref="ArgumentException">Path is null or empty.</exception>
        public static string? GetParent(string path, uint level)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Invalid path.", nameof(path));
            }

            string? parent = path;
            for (uint i = 1; i <= level; ++i)
            {
                if (parent == null)
                {
                    throw new InvalidOperationException("Reached root.");
                }

                parent = GetParent(parent);
            }

            return parent;
        }

        /// <summary>
        /// Returns a minimum positive of the two numbers or zero.
        /// </summary>
        /// <param name="num1">First number to check.</param>
        /// <param name="num2">Second number to check.</param>
        /// <returns>A minimum positive number or zero.</returns>
        public static int MinPositiveOrZero(int num1, int num2)
        {
            if (num1 < 0 && num2 < 0)
            {
                return 0;
            }

            if (num1 < 0)
            {
                return num2;
            }

            if (num2 < 0)
            {
                return num1;
            }

            return Math.Min(num1, num2);
        }
    }
}