/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Extensions;
using System;
using System.IO;

namespace PerpetualIntelligence.Shared.Services
{
    /// <summary>
    /// <see cref="System.IO"/> helper methods.
    /// </summary>
    public static class IOHelper
    {
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
                // Full name return the current directory for relative paths.
                string parentPath = Directory.GetParent(path).FullName.TrimStart(Directory.GetCurrentDirectory());
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
                if(parent == null)
                {
                    throw new InvalidOperationException("Reached root.");
                }

                parent = GetParent(parent);
                
            }

            return parent;
        }
    }
}
