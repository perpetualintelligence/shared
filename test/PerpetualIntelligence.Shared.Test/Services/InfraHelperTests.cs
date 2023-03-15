/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.IO;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class InfraHelperTests
    {
        [TestMethod]
        public void GetParentTest()
        {
            // Support linux and windows
            string path = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            string expPath = Path.Combine("home", "shared", "shared", "src", "bin");
            Assert.AreEqual(expPath, InfraHelper.GetParent(path));

            string path2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            Assert.AreEqual(expPath2, InfraHelper.GetParent(path2));
        }

        [TestMethod]
        public void GetParentTestLevels()
        {
            // Support linux and windows
            string path = Path.Combine("home", "shared", "shared", "src", "bin", "debug");
            string expPath = Path.Combine("home", "shared", "shared");
            Assert.AreEqual(expPath, InfraHelper.GetParent(path, 3));

            string path2 = Path.Combine("home", "shared", "shared", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "shared", "shared", "src");
            Assert.AreEqual(expPath2, InfraHelper.GetParent(path2, 3));
        }

        [TestMethod]
        public void MinPositiveOrZeroTest()
        {
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(-1, -1));
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(-1, 0));
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(0, -1));
            Assert.AreEqual(2, InfraHelper.MinPositiveOrZero(-1, 2));
            Assert.AreEqual(3, InfraHelper.MinPositiveOrZero(3, -1));
            Assert.AreEqual(5, InfraHelper.MinPositiveOrZero(-2, 5));
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(0, 0));
            Assert.AreEqual(3, InfraHelper.MinPositiveOrZero(3, 5));
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(0, 2));
            Assert.AreEqual(0, InfraHelper.MinPositiveOrZero(3, 0));
        }

        [TestMethod]
        public void NullOrEmptyParentShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => InfraHelper.GetParent(null), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => InfraHelper.GetParent("  "), "Invalid path. (Parameter 'path')");
        }

        [TestMethod]
        public void NullOrEmptyParentWithLevelsShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => InfraHelper.GetParent(null, 2), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => InfraHelper.GetParent("  ", 2), "Invalid path. (Parameter 'path')");
        }
    }
}