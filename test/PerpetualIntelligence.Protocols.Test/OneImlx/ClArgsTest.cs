/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class ClArgsTest
    {
        [TestMethod]
        public void InternalCommandLineArgumentsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ClArgs), 2);

            Assert.AreEqual("oneimlxargcontrollerasservice", ClArgs.ControllerAsService);
            Assert.AreEqual("oneimlxargenablelogger", ClArgs.EnableLogger);
        }
    }
}
