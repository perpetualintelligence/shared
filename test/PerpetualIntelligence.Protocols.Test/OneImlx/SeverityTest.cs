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
    public class SeverityTest
    {
        [TestMethod]
        public void SeverityConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Severity), 5);

            Assert.AreEqual("urn:oneimlx:severity:crit", Severity.Critical);
            Assert.AreEqual("urn:oneimlx:severity:high", Severity.High);
            Assert.AreEqual("urn:oneimlx:severity:low", Severity.Low);
            Assert.AreEqual("urn:oneimlx:severity:med", Severity.Medium);
            Assert.AreEqual("urn:oneimlx:severity:tbd", Severity.Tbd);
        }
    }
}
