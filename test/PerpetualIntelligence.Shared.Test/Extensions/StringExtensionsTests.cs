/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using System;
using Xunit;

namespace PerpetualIntelligence.Shared.Extensions
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNotNullOrWhiteSpaceTest()
        {
            StringExtensions.IsNotNullOrWhiteSpace("").Should().BeFalse();

            StringExtensions.IsNotNullOrWhiteSpace("  ").Should().BeFalse();

            StringExtensions.IsNotNullOrWhiteSpace(null).Should().BeFalse();

            StringExtensions.IsNotNullOrWhiteSpace("Test").Should().BeTrue();
        }

        [Fact]
        public void IsNullOrEmptyTest()
        {
            StringExtensions.IsNullOrEmpty("").Should().BeTrue();

            StringExtensions.IsNullOrEmpty("  ").Should().BeFalse();

            StringExtensions.IsNullOrEmpty(null).Should().BeTrue();

            StringExtensions.IsNullOrEmpty("Test").Should().BeFalse();
        }

        [Fact]
        public void IsNullOrWhiteSpaceTest()
        {
            StringExtensions.IsNullOrWhiteSpace("").Should().BeTrue();

            StringExtensions.IsNullOrWhiteSpace("  ").Should().BeTrue();

            StringExtensions.IsNullOrWhiteSpace(null).Should().BeTrue();

            StringExtensions.IsNullOrWhiteSpace("Test").Should().BeFalse();
        }

        [Fact]
        public void JoinSpaceTest()
        {
            StringExtensions.JoinBySpace(new string[] { "test1", "test2", "test3" }).Should().Be("test1 test2 test3");
        }

        [Fact]
        public void JoinSpaceWithMultipleSpaceTest()
        {
            StringExtensions.JoinBySpace(new string[] { "test1", " test2", "test3", "test4    " }).Should().Be("test1  test2 test3 test4    ");
        }

        [Fact]
        public void SplitSpaceTest()
        {
            string[] parts = { "test1", "test2", "test3" };
            parts.Should().ContainInOrder("test1 test2 test3".SplitBySpace());
        }

        [Fact]
        public void SplitSpaceWithMultipleSpacesTest()
        {
            string[] parts = { "test1", "", "test2", "test3", "", "", "test4", "", "" };
            parts.Should().ContainInOrder("test1  test2 test3   test4  ".SplitBySpace());
        }

        [Fact]
        public void JoinNewlineTest()
        {
            StringExtensions.JoinByNewline(new string[] { "test1", "test2", "test3", "test4" }).Should().Be($"test1{Environment.NewLine}test2{Environment.NewLine}test3{Environment.NewLine}test4");
        }

        [Fact]
        public void SplitNewlineTest()
        {
            string[] parts = { "test1", "test2", "test3" };
            parts.Should().ContainInOrder($"test1{Environment.NewLine}test2{Environment.NewLine}test3".SplitByNewline());
        }

        [Fact]
        public void StringRepeatShouldRepeadCorrectly()
        {
            "x".Repeat(10).Should().Be("xxxxxxxxxx");
            "x".Repeat(100).Should().Be("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            "x".Repeat(10).Length.Should().Be(10);
            "x".Repeat(100).Length.Should().Be(100);
        }

        [Fact]
        public void TrimEndRecursive()
        {
            string test = "arg=value#";
            test.TrimEnd("#", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "~arg=value#";
            test.TrimEnd("#", System.StringComparison.InvariantCulture).Should().Be("~arg=value");

            test = "arg=value####";
            test.TrimEnd("#", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "arg=value####";
            test.TrimEnd("##", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "arg=value####";
            test.TrimEnd("###", System.StringComparison.InvariantCulture).Should().Be("arg=value#");

            test = "arg=value####";
            test.TrimEnd("####", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "arg=value##  ##";
            test.TrimEnd("####", System.StringComparison.InvariantCulture).Should().Be("arg=value##  ##");
        }

        [Fact]
        public void TrimEndRecursiveUnicode()
        {
            string test = "arg=valueöö";
            test.TrimEnd("öö", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "arg=valueöö";
            test.TrimEnd("ö", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "arg=valueमाणूस";
            test.TrimEnd("माणूस", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "arg=valueमाणूस";
            test.TrimEnd("णूस", System.StringComparison.Ordinal).Should().Be("arg=valueमा");

            test = "arg=valueमा    णूस";
            test.TrimEnd("णूस", System.StringComparison.Ordinal).Should().Be("arg=valueमा    ");

            test = "माणूस की चान अहे";
            test.TrimEnd(" चान अहे", System.StringComparison.Ordinal).Should().Be("माणूस की");

            test = "माणूस की चान अहे माणूसमाणूमाणू";
            test.TrimEnd("माणू", System.StringComparison.Ordinal).Should().Be("माणूस की चान अहे माणूस");
        }

        [Fact]
        public void TrimStartRecursive()
        {
            string test = "#arg=value";
            test.TrimStart("#", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "#~arg=value";
            test.TrimStart("#", System.StringComparison.InvariantCulture).Should().Be("~arg=value");

            test = "####arg=value";
            test.TrimStart("#", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "####arg=value";
            test.TrimStart("##", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "####arg=value";
            test.TrimStart("###", System.StringComparison.InvariantCulture).Should().Be("#arg=value");

            test = "####arg=value";
            test.TrimStart("####", System.StringComparison.InvariantCulture).Should().Be("arg=value");

            test = "##  ##arg=value";
            test.TrimStart("####", System.StringComparison.InvariantCulture).Should().Be("##  ##arg=value");
        }

        [Fact]
        public void TrimStartRecursiveUnicode()
        {
            string test = "ööarg=value";
            test.TrimStart("öö", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "ööarg=value";
            test.TrimStart("ö", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "माणूसarg=value";
            test.TrimStart("माणूस", System.StringComparison.Ordinal).Should().Be("arg=value");

            test = "माणूसarg=value";
            test.TrimStart("माणू", System.StringComparison.Ordinal).Should().Be("सarg=value");

            test = "माणू    सarg=value";
            test.TrimStart("माणू", System.StringComparison.Ordinal).Should().Be("    सarg=value");

            test = "माणूस की चान अहे";
            test.TrimStart("माणूस की ", System.StringComparison.Ordinal).Should().Be("चान अहे");

            test = "माणूमाणूसमाणूस माणूस की चान अहे";
            test.TrimStart("माणू", System.StringComparison.Ordinal).Should().Be("समाणूस माणूस की चान अहे");
        }
    }
}