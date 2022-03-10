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
            TestHelper.AssertConstantCount(typeof(Error), 6);

            Assert.AreEqual("invalid_configuration", Error.InvalidConfiguration);
            Assert.AreEqual("invalid_request", Error.InvalidRequest);
            Assert.AreEqual("not_found", Error.NotFound);
            Assert.AreEqual("server_request", Error.ServerError);
            Assert.AreEqual("unauthorized_access", Error.Unauthorized);
            Assert.AreEqual("unexpected_error", Error.Unexpected);
        }
    }
}
