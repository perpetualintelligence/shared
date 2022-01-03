/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.IO;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class IOHelperTests
    {
        [TestMethod]
        public void GetParentTest()
        {
            // Support linux and windows
            string path = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            string expPath = Path.Combine("home", "protocols", "protocols", "src", "bin");
            Assert.AreEqual(expPath, IOHelper.GetParent(path));

            string path2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            Assert.AreEqual(expPath2, IOHelper.GetParent(path2));
        }

        [TestMethod]
        public void GetParentTestLevels()
        {
            // Support linux and windows
            string path = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            string expPath = Path.Combine("home", "protocols", "protocols");
            Assert.AreEqual(expPath, IOHelper.GetParent(path, 3));

            string path2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "protocols", "protocols", "src");
            Assert.AreEqual(expPath2, IOHelper.GetParent(path2, 3));
        }

        [TestMethod]
        public void NullOrEmptyParentShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent(null), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent("  "), "Invalid path. (Parameter 'path')");
        }

        [TestMethod]
        public void NullOrEmptyParentWithLevelsShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent(null, 2), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent("  ", 2), "Invalid path. (Parameter 'path')");
        }
    }
}
