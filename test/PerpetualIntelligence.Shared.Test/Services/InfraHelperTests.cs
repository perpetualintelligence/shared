/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace PerpetualIntelligence.Shared.Services
{
    public class InfraHelperTests
    {
        [Fact]
        public void GetParentTest()
        {
            // Support linux and windows
            string path = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            string expPath = Path.Combine("home", "shared", "shared", "src", "bin");
            InfraHelper.GetParent(path).Should().Be(expPath);

            string path2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            InfraHelper.GetParent(path2).Should().Be(expPath2);
        }

        [Fact]
        public void GetParentTestLevels()
        {
            // Support linux and windows
            string path = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            string expPath = Path.Combine("home", "shared", "shared");
            InfraHelper.GetParent(path, 3).Should().Be(expPath);

            string path2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "shared", "shared", "src");
            InfraHelper.GetParent(path2, 3).Should().Be(expPath2);
        }

        [Fact]
        public void MinPositiveOrZeroTest()
        {
            InfraHelper.MinPositiveOrZero(-1, -1).Should().Be(0);
            InfraHelper.MinPositiveOrZero(-1, 0).Should().Be(0);
            InfraHelper.MinPositiveOrZero(0, -1).Should().Be(0);
            InfraHelper.MinPositiveOrZero(-1, 2).Should().Be(2);
            InfraHelper.MinPositiveOrZero(3, -1).Should().Be(3);
            InfraHelper.MinPositiveOrZero(-2, 5).Should().Be(5);
            InfraHelper.MinPositiveOrZero(0, 0).Should().Be(0);
            InfraHelper.MinPositiveOrZero(3, 5).Should().Be(3);
            InfraHelper.MinPositiveOrZero(0, 2).Should().Be(0);
            InfraHelper.MinPositiveOrZero(3, 0).Should().Be(0);
        }

        [Fact]
        public void NullOrEmptyParentShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act = () => InfraHelper.GetParent(null);
            act.Should().Throw<ArgumentException>().WithMessage("Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Action act2 = () => InfraHelper.GetParent("  ");
            act2.Should().Throw<ArgumentException>().WithMessage("Invalid path. (Parameter 'path')");
        }

        [Fact]
        public void NullOrEmptyParentWithLevelsShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Action act = () => InfraHelper.GetParent(null, 2);
            act.Should().Throw<ArgumentException>().WithMessage("Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Action act2 = () => InfraHelper.GetParent("  ", 2);
            act2.Should().Throw<ArgumentException>().WithMessage("Invalid path. (Parameter 'path')");
        }
    }
}