//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

using System;
using FluentAssertions;
using FluentAssertions.Execution;
using OneImlx.Shared.Infrastructure;
using Xunit;

namespace OneImlx.Test.FluentAssertions
{
    public class AssemblyFluentAssertionsTests
    {
        [Fact]
        public void HaveTypesInRootNamespace_PassesWhenAssemblyNameMatchesRootNamespace()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInRootNamespace("OneImlx.Test");
            act.Should().NotThrow();
        }

        [Fact]
        public void HaveTypesInRootNamespace_PassesForNestedNamespacesUnderRoot()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInRootNamespace("OneImlx.Test");
            act.Should().NotThrow();
        }

        [Fact]
        public void HaveTypesInRootNamespace_ThrowsWhenAssemblyNameDoesNotMatchRootNamespace()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInRootNamespace("WrongNamespace");
            act.Should().Throw<AssertionFailedException>().WithMessage("*Assembly 'OneImlx.Test' should have root namespace 'WrongNamespace'*");
        }

        [Fact]
        public void HaveTypesInRootNamespace_ThrowsWhenNamespaceIsConcatenationWithoutNesting()
        {
            // "OneImlx.TestXYZ" starts with "OneImlx.Test" but "XYZ" is not "." — treated as concatenation, not nesting
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInRootNamespace("OneImlx.TestXYZ");
            act.Should().Throw<AssertionFailedException>().WithMessage("*Assembly 'OneImlx.Test' should have root namespace 'OneImlx.TestXYZ'*");
        }

        [Fact]
        public void HaveTypesInRootNamespace_ReturnsAndConstraintForChaining()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            var result = assembly.Should().HaveTypesInRootNamespace("OneImlx.Test");
            result.Should().NotBeNull();
        }

        [Fact]
        public void HaveTypesInValidLocations_PassesForOneImlxTestAssembly()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInValidLocations();
            act.Should().NotThrow();
        }

        [Fact]
        public void HaveTypesInValidLocations_ThrowsWhenExcludedTypeCreatesFilesCountMismatch()
        {
            // Excluding ObjectExtensions removes the type but the .cs file still exists on disk,
            // so type count (0) != file count (1) for namespace OneImlx.Test.Extentions
            var excludeTypes = new[] { typeof(Extentions.ObjectExtensions) };
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            Action act = () => assembly.Should().HaveTypesInValidLocations(excludeTypes);
            act.Should().Throw<ErrorException>()
               .WithMessage("Namespace 'OneImlx.Test.Extentions' has 0 types, but it has 1 source files.");
        }

        [Fact]
        public void HaveTypesInValidLocations_ReturnsAndConstraintForChaining()
        {
            var assembly = typeof(AssemblyFluentAssertions).Assembly;
            var result = assembly.Should().HaveTypesInValidLocations();
            result.Should().NotBeNull();
        }
    }
}