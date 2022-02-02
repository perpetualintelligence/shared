/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
            TestHelper.AssertConstantCount(typeof(Errors), 9);

            Assert.AreEqual("invalid_command", Errors.InvalidCommand);
            Assert.AreEqual("invalid_configuration", Errors.InvalidConfiguration);
            Assert.AreEqual("invalid_argument", Errors.InvalidArgument);
            Assert.AreEqual("duplicate_argument", Errors.DuplicateArgument);
            Assert.AreEqual("invalid_request", Errors.InvalidRequest);
            Assert.AreEqual("unsupported_argument", Errors.UnsupportedArgument);
            Assert.AreEqual("unsupported_command", Errors.UnsupportedCommand);
            Assert.AreEqual("server_error", Errors.ServerError);
            Assert.AreEqual("missing_argument", Errors.MissingArgument);
        }
    }
}
