/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Cli
{
    [TestClass]
    public class ErrorsTest
    {
        [TestMethod]
        public void AssertErrorsAreValid()
        {
            TestHelper.AssertConstantCount(typeof(Errors), 6);

            Assert.AreEqual("invalid_command", Errors.InvalidCommand);
            Assert.AreEqual("invalid_configuration", Errors.InvalidConfiguration);
            Assert.AreEqual("invalid_argument", Errors.InvalidArgument);
            Assert.AreEqual("invalid_request", Errors.InvalidRequest);
            Assert.AreEqual("unsupported_argument", Errors.UnsupportedArgument);
            Assert.AreEqual("server_error", Errors.ServerError);
            Assert.AreEqual("missing_argument", Errors.MissingArgument);
        }
    }
}
