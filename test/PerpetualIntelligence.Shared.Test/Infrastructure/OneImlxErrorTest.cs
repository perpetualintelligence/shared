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

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class OneImlxErrorTest
    {
        [TestMethod]
        public void CtorNoErrorShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new OneImlxError(null), "'error' cannot be null or whitespace. (Parameter 'error')");
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new OneImlxError("   "), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [TestMethod]
        public void CtorShouldSetCorrectly()
        {
            OneImlxError error = new("error", "desc", "uri", "rid");
            Assert.AreEqual("error", error.Error);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
        }

        [TestMethod]
        public void JsonPropertyNameShoudBeValid()
        {
            Type type = typeof(OneImlxError);
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(OneImlxError.Error)), "error");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(OneImlxError.ErrorDescription)), "error_description");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(OneImlxError.ErrorUri)), "error_uri");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(OneImlxError.RequestId)), "request_id");
        }

        [TestMethod]
        public void NewInstanceShouldError()
        {
            OneImlxError error = new();
            Assert.AreEqual("unexpected_error", error.Error);
            Assert.IsNull(error.ErrorDescription);
            Assert.IsNull(error.ErrorUri);
            Assert.IsNull(error.RequestId);
        }

        [TestMethod]
        public void SetErrorNoErrorShouldThrow()
        {
            var error = new OneImlxError();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError(null), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("   "), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void SetErrorShouldSetCorrectly()
        {
            OneImlxError error = new();
            error.SetError("error", "desc", "uri", "rid");
            Assert.AreEqual("error", error.Error);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
        }
    }
}
