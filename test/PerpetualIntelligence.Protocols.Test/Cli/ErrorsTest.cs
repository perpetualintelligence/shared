/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
            TestHelper.AssertConstantCount(typeof(Errors), 7);

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
