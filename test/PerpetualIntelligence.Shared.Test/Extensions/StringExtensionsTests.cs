/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
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
            Assert.AreEqual("test1 test2 test3", StringExtensions.JoinBySpace(new string[] { "test1", "test2", "test3" }));
        }

        [TestMethod]
        public void TrimStart()
        {
            string test = "#arg=value";
            Assert.AreEqual("arg=value", test.TrimStart("#"));

            test = "#~arg=value";
            Assert.AreEqual("~arg=value", test.TrimStart("#"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStart("#"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStart("##"));

            test = "####arg=value";
            Assert.AreEqual("#arg=value", test.TrimStart("###"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStart("####"));

            test = "##  ##arg=value";
            Assert.AreEqual("##  ##arg=value", test.TrimStart("####"));
        }

        [TestMethod]
        public void TrimStartUnicode()
        {
            string test = "ööarg=value";
            Assert.AreEqual("arg=value", test.TrimStart("öö"));

            test = "ööarg=value";
            Assert.AreEqual("arg=value", test.TrimStart("ö"));

            test = "माणूसarg=value";
            Assert.AreEqual("arg=value", test.TrimStart("माणूस"));

            test = "माणूसarg=value";
            Assert.AreEqual("सarg=value", test.TrimStart("माणू"));

            test = "माणू    सarg=value";
            Assert.AreEqual("    सarg=value", test.TrimStart("माणू"));

            test = "माणूस की चान अहे";
            Assert.AreEqual("चान अहे", test.TrimStart("माणूस की "));

            test = "माणूमाणूसमाणूस माणूस की चान अहे";
            Assert.AreEqual("समाणूस माणूस की चान अहे", test.TrimStart("माणू"));
        }
    }
}
