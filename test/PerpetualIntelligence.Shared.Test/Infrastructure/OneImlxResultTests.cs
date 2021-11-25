/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class OneImlxResultTests
    {
        [TestMethod]
        public void AddErrorObjectShouldAddTheError()
        {
            OneImlxResult result = new();

            OneImlxError error = new()
            {
                Error = "test_error",
                ErrorDescription = "test_error_desc",
                ErrorUri = "test_error_uri",
                RequestId = "test_request_id",
            };

            result.AddError(error);
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            OneImlxError error2 = result.Errors[0];
            Assert.AreEqual("test_error", error2.Error);
            Assert.AreEqual("test_error_desc", error2.ErrorDescription);
            Assert.AreEqual("test_error_uri", error2.ErrorUri);
            Assert.AreEqual("test_request_id", error2.RequestId);
        }

        [TestMethod]
        public void AddErrorObjWithoutErrorCodeShouldThrow()
        {
            OneImlxResult result = new();
            OneImlxError error = new()
            {
                Error = ""
            };

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error), "'Error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void AddErrorShouldAddTheError()
        {
            OneImlxResult result = new();

            result.AddError("test_error", "test_error_desc", "test_error_uri", "test_request_id");
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            OneImlxError error = result.Errors[0];
            Assert.AreEqual("test_error", error.Error);
            Assert.AreEqual("test_error_desc", error.ErrorDescription);
            Assert.AreEqual("test_error_uri", error.ErrorUri);
            Assert.AreEqual("test_request_id", error.RequestId);
        }

        [TestMethod]
        public void AddErrorWithoutErrorCodeShouldThrow()
        {
            OneImlxResult result = new();

            // null
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error: null, errorDescription: null), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            // whitespace
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error: "  "), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void DefaultInstanceShouldNotContainAnyError()
        {
            OneImlxResult result = new();
            Assert.IsFalse(result.IsError);
        }

        [TestMethod]
        public void FirstErrorDescriptionShouldReturnCorrectDescription()
        {
            OneImlxResult result = new();
            result.AddError("test_error1", "test_error_desc1");
            result.AddError("test_error2", "test_error_desc2");
            result.AddError("test_error3", "test_error_desc3");

            Assert.IsNotNull(result.FirstError);
            Assert.AreEqual("test_error_desc1", result.FirstError.ErrorDescription);
            Assert.AreEqual("test_error_desc1", result.FirstErrorDescription);
        }

        [TestMethod]
        public void FirstErrorShouldReturnCorrectError()
        {
            OneImlxResult result = new();
            result.AddError("test_error1");
            result.AddError("test_error2");
            result.AddError("test_error3");

            Assert.IsNotNull(result.FirstError);
            Assert.AreEqual("test_error1", result.FirstError.Error);
            Assert.AreEqual("test_error1", result.FirstErrorCode);
        }

        [TestMethod]
        public void NoErrorShouldRemoveAllError()
        {
            OneImlxResult result = new();
            result.AddError("test_error1");
            result.AddError("test_error2");

            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(2, result.Errors.Length);
            Assert.IsTrue(result.IsError);

            result.NoError();
            Assert.IsNull(result.Errors);
            Assert.IsFalse(result.IsError);
        }

        [TestMethod]
        public void SetErrorShouldRemovePreviousErrors()
        {
            OneImlxResult result = new();
            result.AddError("test_error1");
            result.AddError("test_error2");

            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(2, result.Errors.Length);
            Assert.IsTrue(result.IsError);
            Assert.AreEqual("test_error1", result.Errors[0].Error);
            Assert.AreEqual("test_error2", result.Errors[1].Error);

            result.SetError("test_error3");
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);
            Assert.IsTrue(result.IsError);
            Assert.AreEqual("test_error3", result.Errors[0].Error);
        }

        [TestMethod]
        public void SyncErrorShouldRemovePreviousAndSetInputError()
        {
            OneImlxResult result = new();
            result.AddError("test_error1");
            result.AddError("test_error2");
            result.AddError("test_error3");

            OneImlxResult input = new OneImlxResult();
            input.AddError("test_error3", "test_error_desc3", "test_error_uri3", "test_request_id3");

            result.SyncError(input);
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            OneImlxError syncError = result.Errors[0];
            Assert.AreEqual("test_error3", syncError.Error);
            Assert.AreEqual("test_error_desc3", syncError.ErrorDescription);
            Assert.AreEqual("test_error_uri3", syncError.ErrorUri);
            Assert.AreEqual("test_request_id3", syncError.RequestId);
        }
    }
}
