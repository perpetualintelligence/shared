/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error(null), "'error' cannot be null or whitespace. (Parameter 'error')");
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("   "), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [TestMethod]
        public void CtorShouldSetCorrectly()
        {
            Error error = new("error", "desc", "uri", "rid");
            Assert.AreEqual("error", error.ErrorCode);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
        }

        [TestMethod]
        public void JsonPropertyNameShoudBeValid()
        {
            Type type = typeof(Error);
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorCode)), "error");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorDescription)), "error_description");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.ErrorUri)), "error_uri");
            TestHelper.AssertJsonPropertyName(type.GetProperty(nameof(Error.RequestId)), "request_id");
        }

        [TestMethod]
        public void NewInstanceShouldError()
        {
            Error error = new();
            Assert.AreEqual("unexpected_error", error.ErrorCode);
            Assert.IsNull(error.ErrorDescription);
            Assert.IsNull(error.ErrorUri);
            Assert.IsNull(error.RequestId);
        }

        [TestMethod]
        public void SetErrorNoErrorShouldThrow()
        {
            var error = new Error();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError(null), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("   "), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void SetErrorShouldSetCorrectly()
        {
            Error error = new();
            error.SetError("error", "desc", "uri", "rid");
            Assert.AreEqual("error", error.ErrorCode);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
        }
    }
}
