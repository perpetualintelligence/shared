/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;
using System;
using System.IO;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class SharedHelperTests
    {
        [TestMethod]
        public void FormatDefaultShouldNotRevealArguments()
        {
            LoggingOptions loggingOptions = new();
            string message = SharedHelper.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatShouldNotRevealArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string message = SharedHelper.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatShouldRevealArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };
            string message = SharedHelper.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void GetParentTest()
        {
            // Support linux and windows
            string path = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            string expPath = Path.Combine("home", "protocols", "protocols", "src", "bin");
            Assert.AreEqual(expPath, SharedHelper.GetParent(path));

            string path2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            Assert.AreEqual(expPath2, SharedHelper.GetParent(path2));
        }

        [TestMethod]
        public void GetParentTestLevels()
        {
            // Support linux and windows
            string path = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug");
            string expPath = Path.Combine("home", "protocols", "protocols");
            Assert.AreEqual(expPath, SharedHelper.GetParent(path, 3));

            string path2 = Path.Combine("home", "protocols", "protocols", "src", "bin", "debug", "file.txt");
            string expPath2 = Path.Combine("home", "protocols", "protocols", "src");
            Assert.AreEqual(expPath2, SharedHelper.GetParent(path2, 3));
        }

        [TestMethod]
        public void MinPositiveOrZeroTest()
        {
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(-1, -1));
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(-1, 0));
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(0, -1));
            Assert.AreEqual(2, SharedHelper.MinPositiveOrZero(-1, 2));
            Assert.AreEqual(3, SharedHelper.MinPositiveOrZero(3, -1));
            Assert.AreEqual(5, SharedHelper.MinPositiveOrZero(-2, 5));
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(0, 0));
            Assert.AreEqual(3, SharedHelper.MinPositiveOrZero(3, 5));
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(0, 2));
            Assert.AreEqual(0, SharedHelper.MinPositiveOrZero(3, 0));
        }

        [TestMethod]
        public void NullOrEmptyParentShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => SharedHelper.GetParent(null), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => SharedHelper.GetParent("  "), "Invalid path. (Parameter 'path')");
        }

        [TestMethod]
        public void NullOrEmptyParentWithLevelsShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => SharedHelper.GetParent(null, 2), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => SharedHelper.GetParent("  ", 2), "Invalid path. (Parameter 'path')");
        }

        [TestMethod]
        public void ObscureShouldBehaveCorrectly()
        {
            var result = SharedHelper.Obscure("----", new object?[] { "test1", "    ", "", null, true, 2503.36, 69, -9, "test4" });
            CollectionAssert.AreEqual(new object[] { "----", "----", "----", "----", "----", "----", "----", "----", "----" }, result);
        }
    }
}
