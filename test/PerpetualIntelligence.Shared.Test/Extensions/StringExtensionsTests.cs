/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNotNullOrWhiteSpaceTest()
        {
            Assert.IsFalse(StringExtensions.IsNotNullOrWhiteSpace(""));

            Assert.IsFalse(StringExtensions.IsNotNullOrWhiteSpace("  "));

            Assert.IsFalse(StringExtensions.IsNotNullOrWhiteSpace(null));

            Assert.IsTrue(StringExtensions.IsNotNullOrWhiteSpace("Test"));
        }

        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            Assert.IsTrue(StringExtensions.IsNullOrEmpty(""));

            Assert.IsFalse(StringExtensions.IsNullOrEmpty("  "));

            Assert.IsTrue(StringExtensions.IsNullOrEmpty(null));

            Assert.IsFalse(StringExtensions.IsNullOrEmpty("Test"));
        }

        [TestMethod]
        public void IsNullOrWhiteSpaceTest()
        {
            Assert.IsTrue(StringExtensions.IsNullOrWhiteSpace(""));

            Assert.IsTrue(StringExtensions.IsNullOrWhiteSpace("  "));

            Assert.IsTrue(StringExtensions.IsNullOrWhiteSpace(null));

            Assert.IsFalse(StringExtensions.IsNullOrWhiteSpace("Test"));
        }

        [TestMethod]
        public void JoinSpaceTest()
        {
            Assert.AreEqual("test1 test2 test3", StringExtensions.JoinSpace(new string[] { "test1", "test2", "test3" }));
        }
    }
}
