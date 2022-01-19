/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
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
        public void StringRepeatShouldRepeadCorrectly()
        {
            Assert.AreEqual("xxxxxxxxxx", "x".Repeat(10));
            Assert.AreEqual("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "x".Repeat(100));

            Assert.AreEqual(10, "x".Repeat(10).Length);
            Assert.AreEqual(100, "x".Repeat(100).Length);
        }

        [TestMethod]
        public void TrimEndRecursive()
        {
            string test = "arg=value#";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("#"));

            test = "~arg=value#";
            Assert.AreEqual("~arg=value", test.TrimEndRecursive("#"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("#"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("##"));

            test = "arg=value####";
            Assert.AreEqual("arg=value#", test.TrimEndRecursive("###"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("####"));

            test = "arg=value##  ##";
            Assert.AreEqual("arg=value##  ##", test.TrimEndRecursive("####"));
        }

        [TestMethod]
        public void TrimEndRecursiveUnicode()
        {
            string test = "arg=valueöö";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("öö"));

            test = "arg=valueöö";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("ö"));

            test = "arg=valueमाणूस";
            Assert.AreEqual("arg=value", test.TrimEndRecursive("माणूस"));

            test = "arg=valueमाणूस";
            Assert.AreEqual("arg=valueमा", test.TrimEndRecursive("णूस"));

            test = "arg=valueमा    णूस";
            Assert.AreEqual("arg=valueमा    ", test.TrimEndRecursive("णूस"));

            test = "माणूस की चान अहे";
            Assert.AreEqual("माणूस की", test.TrimEndRecursive(" चान अहे"));

            test = "माणूस की चान अहे माणूसमाणूमाणू";
            Assert.AreEqual("माणूस की चान अहे माणूस", test.TrimEndRecursive("माणू"));
        }

        [TestMethod]
        public void TrimStartRecursive()
        {
            string test = "#arg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("#"));

            test = "#~arg=value";
            Assert.AreEqual("~arg=value", test.TrimStartRecursive("#"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("#"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("##"));

            test = "####arg=value";
            Assert.AreEqual("#arg=value", test.TrimStartRecursive("###"));

            test = "####arg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("####"));

            test = "##  ##arg=value";
            Assert.AreEqual("##  ##arg=value", test.TrimStartRecursive("####"));
        }

        [TestMethod]
        public void TrimStartRecursiveUnicode()
        {
            string test = "ööarg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("öö"));

            test = "ööarg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("ö"));

            test = "माणूसarg=value";
            Assert.AreEqual("arg=value", test.TrimStartRecursive("माणूस"));

            test = "माणूसarg=value";
            Assert.AreEqual("सarg=value", test.TrimStartRecursive("माणू"));

            test = "माणू    सarg=value";
            Assert.AreEqual("    सarg=value", test.TrimStartRecursive("माणू"));

            test = "माणूस की चान अहे";
            Assert.AreEqual("चान अहे", test.TrimStartRecursive("माणूस की "));

            test = "माणूमाणूसमाणूस माणूस की चान अहे";
            Assert.AreEqual("समाणूस माणूस की चान अहे", test.TrimStartRecursive("माणू"));
        }
    }
}
