/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Licensing
{
    [TestClass]
    public class SaaSCheckModesTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSUsage()
        {
            Assert.IsFalse(SaaSCheckModes.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSCheckModes.IsValid(SaaSCheckModes.Online));
            Assert.IsTrue(SaaSCheckModes.IsValid(SaaSCheckModes.OnlineThenOffline));
            Assert.IsTrue(SaaSCheckModes.IsValid(SaaSCheckModes.Offline));
            Assert.IsTrue(SaaSCheckModes.IsValid(SaaSCheckModes.OfflineThenOnline));
        }

        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSCheckModes), 4);

            Assert.AreEqual("urn:oneimlx:lic:saascmode:online", SaaSCheckModes.Online);
            Assert.AreEqual("urn:oneimlx:lic:saascmode:onthenoff", SaaSCheckModes.OnlineThenOffline);
            Assert.AreEqual("urn:oneimlx:lic:saascmode:offline", SaaSCheckModes.Offline);
            Assert.AreEqual("urn:oneimlx:lic:saascmode:offthenon", SaaSCheckModes.OfflineThenOnline);
        }
    }
}
