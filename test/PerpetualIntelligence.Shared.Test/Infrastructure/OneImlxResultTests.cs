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
    public class OneImlxResultTests
    {
        [TestMethod]
        public void AddErrorObjectShouldAddTheError()
        {
            Result result = new();

            Error error = new()
            {
                ErrorCode = "test_error",
                ErrorDescription = "test_error_desc",
                ErrorUri = "test_error_uri",
                RequestId = "test_request_id",
            };

            result.AddError(error);
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            Error error2 = result.Errors[0];
            Assert.AreEqual("test_error", error2.ErrorCode);
            Assert.AreEqual("test_error_desc", error2.ErrorDescription);
            Assert.AreEqual("test_error_uri", error2.ErrorUri);
            Assert.AreEqual("test_request_id", error2.RequestId);
        }

        [TestMethod]
        public void AddErrorObjWithoutErrorCodeShouldThrow()
        {
            Result result = new();
            Error error = new()
            {
                ErrorCode = ""
            };

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error), "'ErrorCode' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void AddErrorShouldAddTheError()
        {
            Result result = new();

            result.AddError("test_error", "test_error_desc", "test_error_uri", "test_request_id");
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            Error error = result.Errors[0];
            Assert.AreEqual("test_error", error.ErrorCode);
            Assert.AreEqual("test_error_desc", error.ErrorDescription);
            Assert.AreEqual("test_error_uri", error.ErrorUri);
            Assert.AreEqual("test_request_id", error.RequestId);
        }

        [TestMethod]
        public void AddErrorWithoutErrorCodeShouldThrow()
        {
            Result result = new();

            // null
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error: null, "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            // whitespace
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError(error: "  ", "test1"), "'error' cannot be null or whitespace. (Parameter 'error')");
        }

        [TestMethod]
        public void AddErrorWithoutErrorDescriptionShouldThrow()
        {
            Result result = new();

            // null
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError("test1", null), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            // whitespace
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.AddError("test1", "   "), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
        }

        [TestMethod]
        public void DefaultInstanceShouldNotContainAnyError()
        {
            Result result = new();
            Assert.IsFalse(result.IsError);
        }

        [TestMethod]
        public void FirstErrorDescriptionShouldReturnCorrectDescription()
        {
            Result result = new();
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
            Result result = new();
            result.AddError("test_error1", "test_desc1");
            result.AddError("test_error2", "test_desc2");
            result.AddError("test_error3", "test_desc3");

            Assert.IsNotNull(result.FirstError);
            Assert.AreEqual("test_error1", result.FirstError.ErrorCode);
            Assert.AreEqual("test_error1", result.FirstErrorCode);
        }

        [TestMethod]
        public void NewErrorShouldHaveErrorParms()
        {
            Error error = new()
            {
                ErrorCode = "test_error",
                ErrorDescription = "test_error_desc",
                ErrorUri = "test_error_uri",
                RequestId = "test_request_id"
            };

            var result = Result.NewError<Result>(error);
            Assert.IsTrue(result.IsError);
            Assert.IsNotNull(result.FirstError);
            Assert.AreEqual("test_error", result.FirstError.ErrorCode);
            Assert.AreEqual("test_error_desc", result.FirstError.ErrorDescription);
            Assert.AreEqual("test_error_uri", result.FirstError.ErrorUri);
            Assert.AreEqual("test_request_id", result.FirstError.RequestId);

            var result2 = Result.NewError<Result>("test_error2", "test_error_desc2", "test_error_uri2", "test_request_id2");
            Assert.IsTrue(result2.IsError);
            Assert.IsNotNull(result2.FirstError);
            Assert.AreEqual("test_error2", result2.FirstError.ErrorCode);
            Assert.AreEqual("test_error_desc2", result2.FirstError.ErrorDescription);
            Assert.AreEqual("test_error_uri2", result2.FirstError.ErrorUri);
            Assert.AreEqual("test_request_id2", result2.FirstError.RequestId);

            // Sync from result
            var result3 = Result.NewError<Result>(result2);
            Assert.IsTrue(result3.IsError);
            Assert.IsNotNull(result3.FirstError);
            Assert.AreEqual("test_error2", result3.FirstError.ErrorCode);
            Assert.AreEqual("test_error_desc2", result3.FirstError.ErrorDescription);
            Assert.AreEqual("test_error_uri2", result3.FirstError.ErrorUri);
            Assert.AreEqual("test_request_id2", result3.FirstError.RequestId);

            // Sync copies the error
            Assert.IsFalse(ReferenceEquals(result2.Errors, result3.Errors));
        }

        [TestMethod]
        public void NewInstanceShouldNotError()
        {
            Result oneImlxResult = new();
            Assert.IsFalse(oneImlxResult.IsError);
        }

        [TestMethod]
        public void NewSuccessShouldNotError()
        {
            var result = Result.NewSuccess<Result>();
            Assert.IsFalse(result.IsError);
        }

        [TestMethod]
        public void NoErrorShouldRemoveAllError()
        {
            Result result = new();
            result.AddError("test_error1", "test_desc1");
            result.AddError("test_error2", "test_desc2");

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
            Result result = new();
            result.AddError("test_error1", "test_desc1");
            result.AddError("test_error2", "test_desc2");

            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(2, result.Errors.Length);
            Assert.IsTrue(result.IsError);
            Assert.AreEqual("test_error1", result.Errors[0].ErrorCode);
            Assert.AreEqual("test_error2", result.Errors[1].ErrorCode);

            result.SetError("test_error3", "test_desc3");
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);
            Assert.IsTrue(result.IsError);
            Assert.AreEqual("test_error3", result.Errors[0].ErrorCode);
        }

        [TestMethod]
        public void SetErrorWithNullOrEmptyShouldThrow()
        {
            // Bug: Microsoft returns ''error

            Result result = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentNullException>(() => result.SetError(error: null), "'error' cannot be null. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.SetError(new Error(null, "test")), "'error' cannot be null or whitespace. (Parameter 'error')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.SetError(new Error("  ", "test")), "'error' cannot be null or whitespace. (Parameter 'error')");

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.SetError(new Error("test", null)), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            //TestHelper.AssertThrowsWithMessage<ArgumentException>(() => result.SetError(new Error("test", "    ")), "'errorDescription' cannot be null or whitespace. (Parameter 'errorDescription')");
        }

        [TestMethod]
        public void SyncErrorShouldRemovePreviousAndSetInputError()
        {
            Result result = new();
            result.AddError("test_error1", "test_desc1");
            result.AddError("test_error2", "test_desc2");
            result.AddError("test_error3", "test_desc3");

            Result input = new();
            input.AddError("test_error3", "test_error_desc3", "test_error_uri3", "test_request_id3");

            result.SyncError(input);
            Assert.IsNotNull(result.Errors);
            Assert.AreEqual(1, result.Errors.Length);

            Error syncError = result.Errors[0];
            Assert.AreEqual("test_error3", syncError.ErrorCode);
            Assert.AreEqual("test_error_desc3", syncError.ErrorDescription);
            Assert.AreEqual("test_error_uri3", syncError.ErrorUri);
            Assert.AreEqual("test_request_id3", syncError.RequestId);
        }
    }
}
