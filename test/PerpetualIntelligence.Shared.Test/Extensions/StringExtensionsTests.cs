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
        public void JoinSpaceWithMultipleSpaceTest()
        {
            Assert.AreEqual("test1  test2 test3 test4    ", StringExtensions.JoinBySpace(new string[] { "test1", " test2", "test3", "test4    " }));
        }

        [TestMethod]
        public void SplitSpaceTest()
        {
            string[] parts = { "test1", "test2", "test3" };
            CollectionAssert.AreEqual(parts, "test1 test2 test3".SplitBySpace());
        }

        [TestMethod]
        public void SplitSpaceWithMultipleSpacesTest()
        {
            string[] parts = { "test1", "", "test2", "test3", "", "", "test4", "", "" };
            CollectionAssert.AreEqual(parts, "test1  test2 test3   test4  ".SplitBySpace());
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
            Assert.AreEqual("arg=value", test.TrimEnd("#"));

            test = "~arg=value#";
            Assert.AreEqual("~arg=value", test.TrimEnd("#"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEnd("#"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEnd("##"));

            test = "arg=value####";
            Assert.AreEqual("arg=value#", test.TrimEnd("###"));

            test = "arg=value####";
            Assert.AreEqual("arg=value", test.TrimEnd("####"));

            test = "arg=value##  ##";
            Assert.AreEqual("arg=value##  ##", test.TrimEnd("####"));
        }

        [TestMethod]
        public void TrimEndRecursiveUnicode()
        {
            string test = "arg=valueöö";
            Assert.AreEqual("arg=value", test.TrimEnd("öö"));

            test = "arg=valueöö";
            Assert.AreEqual("arg=value", test.TrimEnd("ö"));

            test = "arg=valueमाणूस";
            Assert.AreEqual("arg=value", test.TrimEnd("माणूस"));

            test = "arg=valueमाणूस";
            Assert.AreEqual("arg=valueमा", test.TrimEnd("णूस"));

            test = "arg=valueमा    णूस";
            Assert.AreEqual("arg=valueमा    ", test.TrimEnd("णूस"));

            test = "माणूस की चान अहे";
            Assert.AreEqual("माणूस की", test.TrimEnd(" चान अहे"));

            test = "माणूस की चान अहे माणूसमाणूमाणू";
            Assert.AreEqual("माणूस की चान अहे माणूस", test.TrimEnd("माणू"));
        }

        [TestMethod]
        public void TrimStartRecursive()
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
        public void TrimStartRecursiveUnicode()
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
