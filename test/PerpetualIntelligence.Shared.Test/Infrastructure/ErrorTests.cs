/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class ErrorTests
    {
        [TestMethod]
        public void DefaultErrorCodeShouldBeValid()
        {
            TestHelper.AssertConstantCount(typeof(Error), 7);

            Assert.AreEqual("already_exist", Error.AlreadyExist);
            Assert.AreEqual("invalid_configuration", Error.InvalidConfiguration);
            Assert.AreEqual("invalid_request", Error.InvalidRequest);
            Assert.AreEqual("not_found", Error.NotFound);
            Assert.AreEqual("server_error", Error.ServerError);
            Assert.AreEqual("unauthorized_access", Error.Unauthorized);
            Assert.AreEqual("unexpected_error", Error.Unexpected);
        }

        [TestMethod]
        public void CtorNoErrorCodeShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error(null, "test"), "'error' cannot be null or whitespace. (Parameter 'error')");
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("   ", "test"), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [TestMethod]
        public void CtorNoErrorDescriptionShouldThrow()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CA1806 // Do not ignore method results
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("test", null), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => new Error("test", "   "), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CA1806 // Do not ignore method results
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

        [TestMethod]
        public void CtorShouldSetCorrectly()
        {
            Error error = new("error", "desc", null, "uri", "rid");
            Assert.AreEqual("error", error.ErrorCode);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
            Assert.IsNull(error.Args);
        }

        [TestMethod]
        public void JsonPropertyNameShouldBeValid()
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
        public void SetErrorNoErrorDescriptionShouldThrow()
        {
            var error = new Error();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("test1", null), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("test1", "   "), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
        }

        [TestMethod]
        public void SetErrorNoErrorShouldThrow()
        {
            var error = new Error();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError(null, "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => error.SetError("   ", "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void SetErrorShouldSetCorrectly()
        {
            Error error = new();
            error.SetError("error", "desc", new[] { "test1", "test2" }, "uri", "rid");
            Assert.AreEqual("error", error.ErrorCode);
            Assert.AreEqual("desc", error.ErrorDescription);
            Assert.AreEqual("uri", error.ErrorUri);
            Assert.AreEqual("rid", error.RequestId);
            CollectionAssert.AreEqual(new[] { "test1", "test2" }, error.Args);
        }
    }
}
