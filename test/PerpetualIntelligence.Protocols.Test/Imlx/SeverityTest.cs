/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class SeverityTest
    {
        [TestMethod]
        public void SeverityConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Severity), 5);

            Assert.AreEqual("urn:pi:protocol:imlx:severity:crit", Severity.Critical);
            Assert.AreEqual("urn:pi:protocol:imlx:severity:high", Severity.High);
            Assert.AreEqual("urn:pi:protocol:imlx:severity:low", Severity.Low);
            Assert.AreEqual("urn:pi:protocol:imlx:severity:med", Severity.Medium);
            Assert.AreEqual("urn:pi:protocol:imlx:severity:tbd", Severity.Tbd);
        }
    }
}
