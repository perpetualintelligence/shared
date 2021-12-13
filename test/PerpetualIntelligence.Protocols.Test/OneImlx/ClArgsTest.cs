/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
