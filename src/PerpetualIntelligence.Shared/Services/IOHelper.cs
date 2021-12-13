/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

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
        public static string? GetParent(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Invalid path.", nameof(path));
            }

            DirectoryInfo info = new(path);
            if (info.Parent != null)
            {
                return info.Parent.FullName;
            }
            else
            {
                return null;
            }
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
                DirectoryInfo info = new(parent);
                if (info.Parent == null)
                {
                    parent = null;
                    break;
                }

                parent = info.Parent.FullName;
            }

            return parent;
        }
    }
}
