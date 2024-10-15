/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Reflection;
using OneImlx.Shared.Infrastructure;

namespace OneImlx.Test.FluentAssertions
{
    /// <summary>
    /// The fluent assertions for <see cref="Assembly"/>.
    /// </summary>
    public static class AssemblyFluentAssertions
    {
        /// <summary>
        /// Asserts that the assembly has a valid namespace based on its name.
        /// </summary>
        /// <param name="assertions">Fluent Assertions wrapper for the assembly.</param>
        /// <param name="rootNamespace">The expected root namespace.</param>
        public static AndConstraint<AssemblyAssertions> HaveTypesInRootNamespace(this AssemblyAssertions assertions, string rootNamespace)
        {
            var assembly = assertions.Subject;
            var actualNamespace = assembly.GetName().Name ?? throw new InvalidOperationException("Assembly name null");

            Execute.Assertion
                .ForCondition(actualNamespace == rootNamespace)
                .FailWith($"Assembly '{assembly.GetName().Name}' does not have root namespace '{rootNamespace}'.");

            var types = assembly.GetTypes().Where(e => !IsCompilerGenerated(e));
            var invalidTypes = types.Where(e =>
            {
                // Either the namespace should match root namespace or it should be nested namespace. This is to avoid
                if (e.Namespace != null && e.Namespace.StartsWith(rootNamespace))
                {
                    // Make sure do not have any concatenated names to the root namespace without nesting. e.g.
                    // OneImlx.Shared123 - invalid OneImlx.Shared.Services - valid OneImlx.Shared - valid
                    string trimmed = e.Namespace.Replace(rootNamespace, "");
                    if (trimmed == string.Empty || trimmed.StartsWith("."))
                    {
                        // keep
                        return false;
                    }
                }

                // by default filter
                return true;
            });

            if (invalidTypes.Any())
            {
                throw new AssertionFailedException($"Assembly '{assembly.GetName().Name}' contains types '{string.Join(",", invalidTypes.Select(e => e.FullName))}' that do not have root namespace '{rootNamespace}'.");
            }

            return new AndConstraint<AssemblyAssertions>(assertions);
        }

        /// <summary>
        /// Asserts that the assembly has all types in the valid files or locations.
        /// </summary>
        /// <param name="assertions">Fluent Assertions wrapper for the assembly.</param>
        /// <param name="excludeTypes">The types to exclude checks.</param>
        public static AndConstraint<AssemblyAssertions> HaveTypesInValidLocations(this AssemblyAssertions assertions, IEnumerable<Type>? excludeTypes = null)
        {
            var assembly = assertions.Subject;

            // e.g. C:\this\perpetualintelligence\terminal\test\OneImlx.Terminal.Tests\bin\Debug\net8.0\OneImlx.Terminal.dll
            string assemblyPath = GetAssemblyPath(assembly);
            var rootPath = GetRootPathBasedOnAssemblyLocation(assemblyPath);

            var testDir = Path.Combine(rootPath, "test");
            var srcDir = Path.Combine(rootPath, "src");

            Execute.Assertion
                .ForCondition(Directory.Exists(testDir))
                .FailWith("'test' directory not found. path={0}", rootPath);

            Execute.Assertion
                .ForCondition(Directory.Exists(srcDir))
                .FailWith("'src' directory not found. path={0}", rootPath);

            IEnumerable<string?> namespaces = assembly.GetTypes()
                .Where(e => !IsCompilerGenerated(e))
                .Select(e => e.Namespace)
                .Distinct();

            foreach (string? ns in namespaces)
            {
                if (ns == null)
                {
                    throw new InvalidOperationException("Namespace cannot be null.");
                }

                var nsTypes = assembly.GetTypes().Where(e => ns.Equals(e.Namespace) && !IsCompilerGenerated(e));
                ns.Should().NotBeNull("Namespace cannot be null or empty.");
                AssertNamespaceTypesLocation(nsTypes, ns, srcDir, excludeTypes);
            }

            return new AndConstraint<AssemblyAssertions>(assertions);
        }

        /// <summary>
        /// Asserts that the specified types have valid 1-1 src files or location based on the specified namespace.
        /// </summary>
        /// <param name="types">Types to check. All types must be in same assembly.</param>
        /// <param name="namespace">Namespace to check.</param>
        /// <param name="srcDir">src directory.</param>
        /// <param name="excludeTypes">The types to exclude checks.</param>
        private static void AssertNamespaceTypesLocation(IEnumerable<Type> types, string @namespace, string srcDir, IEnumerable<Type>? excludeTypes = null)
        {
            // Check for same assembly.
            Assembly assembly = types.First().Assembly;
            if (!types.All(e => e.Assembly.Equals(assembly)))
            {
                throw new ErrorException("internal_error", "All types must belong to same assembly.");
            }

            //check /src/<prj> dir
            string prjDir = Path.Combine(srcDir, assembly.GetName().Name!);
            if (!Directory.Exists(prjDir))
            {
                prjDir = Path.Combine(srcDir, assembly.GetName().Name!.Replace("OneImlx.", ""));
                if (!Directory.Exists(prjDir))
                {
                    throw new ErrorException("internal_error", "The project directory is not valid.");
                }
            }

            // Get the namespace without the root component.
            string nonRootNamespace = @namespace.Replace(assembly.GetName().Name!, "").TrimStart('.');

            // check namespace dir. Start with project dir and combine all namespace.
            List<string> nDirs = [prjDir, .. nonRootNamespace.Split('.')];
            string namespaceDir = Path.Combine([.. nDirs]);
            if (!Directory.Exists(namespaceDir))
            {
                throw new ErrorException("internal_error", $"The namespace '{@namespace}' is not valid. The namespace component '{nonRootNamespace}' must be a directory.");
            }

            // Make sure the type has the corresponding file. We cannot get the actual code file that defines the type.
            // So we are just checking whether there is a new file for each type and file name matches type. Move this
            // to an analyzer.
            IEnumerable<string>? files = Directory.EnumerateFiles(namespaceDir, "*.cs");
            foreach (Type type in types)
            {
                // Delegates can be in any file
                if (IsDelegate(type))
                {
                    continue;
                }

                // We dont have any control on compiler generated types
                if (IsCompilerGenerated(type))
                {
                    continue;
                }

                // Exclude types
                if (excludeTypes != null && excludeTypes.Contains(type))
                {
                    continue;
                }

                string? typeFile = null;
                if (type.IsGenericType)
                {
                    // Kill everything after `
                    string typeName = type.Name;
                    int index = typeName.IndexOf("`");
                    if (index >= 0)
                    {
                        typeName = typeName.Substring(0, index);
                    }

                    typeFile = Path.Combine(namespaceDir, $"{typeName}.cs");
                }
                else
                {
                    typeFile = Path.Combine(namespaceDir, $"{type.Name}.cs");
                }

                if (!files.Contains(typeFile))
                {
                    throw new ErrorException("internal_error", $"Type '{type.FullName}' must be defined in the src path '{typeFile}'. Please correct the src path or update the namespace.");
                }
            }

            // Make sure the types count matches the files count
            int expectedCount = types.Except(excludeTypes ?? []).Count();
            if (files.Count() != expectedCount)
            {
                throw new ErrorException("internal_error", $"Namespace '{@namespace}' has {expectedCount} types, but it has {files.Count()} source files.");
            }
        }

        private static string GetAssemblyPath(Assembly assembly)
        {
            // Attempt to use CodeBase for full .NET Framework compatibility Fallback to Location for .NET Core and later
            string location;
            try
            {
                // CodeBase is marked obsolete in .NET 5.0 and later versions, but still usable in earlier versions
                location = new Uri(assembly.CodeBase).LocalPath;
            }
            catch (Exception)
            {
                // If accessing CodeBase fails or it's not applicable, use Location
                location = assembly.Location;
            }

            return location;
        }

        private static string GetRootPathBasedOnAssemblyLocation(string assemblyPath)
        {
            // Go up six levels from the assembly location to get to the project root.
            var directory = new DirectoryInfo(assemblyPath);
            for (int i = 0; i < 6; i++)
            {
                directory = directory?.Parent;
                if (directory == null) throw new InvalidOperationException("Failed to calculate the project root path.");
            }

            return directory.FullName;
        }

        private static bool IsCompilerGenerated(Type type)
        {
            if (type.IsDefined(typeof(CompilerGeneratedAttribute)))
            {
                return true;
            }

            if (type.Namespace == null)
            {
                return true;
            }

            // https://github.com/coverlet-coverage/coverlet/issues/1191
            if (type.Namespace == "Coverlet.Core.Instrumentation.Tracker")
            {
                return true;
            }

            if (type.Name.StartsWith("<<"))
            {
                return true;
            }

            // gRPC auto generated types
            if (type.Name.Contains("__"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines if the type is a delegate.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns><c>true</c> if the type is sub class of <see cref="Delegate"/>, otherwise <c>false</c>.</returns>
        private static bool IsDelegate(Type type)
        {
            return type.IsSubclassOf(typeof(Delegate));
        }
    }
}
