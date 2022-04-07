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
    public class SaaSUsageTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSUsage()
        {
            Assert.IsFalse(SaaSUsage.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.CommercialBusiness));
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.CommercialPersonal));
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.Educational));
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.RnD));
        }

        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSUsage), 4);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:org", SaaSUsage.CommercialBusiness);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:per", SaaSUsage.CommercialPersonal);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:edu", SaaSUsage.Educational);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:rnd", SaaSUsage.RnD);
        }
    }
}
