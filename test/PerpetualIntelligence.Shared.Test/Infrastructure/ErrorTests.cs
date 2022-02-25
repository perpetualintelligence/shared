/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class ErrorTests
    {
        [TestMethod]
        public void DefaultErrorCodeShouldBeValid()
        {
            TestHelper.AssertConstantCount(typeof(Error), 3);

            Assert.AreEqual("unauthorized_access", Error.Unauthorized);
            Assert.AreEqual("unknown_error", Error.Unknown);
            Assert.AreEqual("unexpected_error", Error.Unexpected);
        }
    }
}
