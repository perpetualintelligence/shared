/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PerpetualIntelligence.Shared.Extensions
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void NonEmptyListButNullValueAndEmptyValueShouldNotReturnEmpty()
        {
            IEnumerable<string?>? list = new string?[] { "", null };
            Assert.IsFalse(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void NonEmptyListButNullValueAndNonEmptyValueShouldNotReturnEmpty()
        {
            IEnumerable<string?>? list = new string?[] { "test1", null };
            Assert.IsFalse(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void NonEmptyListButNullValueShouldNotReturnEmpty()
        {
            // Contains 1 element but that is null
            IEnumerable<string?>? list = new string?[] { null };
            Assert.IsFalse(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void NonEmptyListShouldNotReturnEmpty()
        {
            IEnumerable<string>? list = new[] { "test1", "test2" };
            Assert.IsFalse(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void NonNullListShouldReturnEmpty()
        {
            IEnumerable<string>? list = System.Array.Empty<string>();
            Assert.IsTrue(list.IsNullOrEmpty());
        }

        [TestMethod]
        public void NullListShouldReturnEmpty()
        {
            IEnumerable<string>? list = null;
            Assert.IsTrue(list.IsNullOrEmpty());
        }
    }
}
