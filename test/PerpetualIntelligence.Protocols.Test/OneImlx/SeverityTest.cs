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
