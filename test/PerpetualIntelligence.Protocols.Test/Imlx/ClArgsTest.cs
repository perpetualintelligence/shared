/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class ClArgsTest
    {
        [TestMethod]
        public void InternalCommandLineArgumentsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ClArgs), 2);

            Assert.AreEqual("piargcontrollerasservice", ClArgs.ControllerAsService);
            Assert.AreEqual("piargenablelogger", ClArgs.EnableLogger);
        }
    }
}
