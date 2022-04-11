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
    public class SaaSUsagesTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSUsage()
        {
            Assert.IsFalse(SaaSUsages.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSUsages.IsValid(SaaSUsages.CommercialBusiness));
            Assert.IsTrue(SaaSUsages.IsValid(SaaSUsages.CommercialPersonal));
            Assert.IsTrue(SaaSUsages.IsValid(SaaSUsages.Educational));
            Assert.IsTrue(SaaSUsages.IsValid(SaaSUsages.RnD));
        }

        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSUsages), 4);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:org", SaaSUsages.CommercialBusiness);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:per", SaaSUsages.CommercialPersonal);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:edu", SaaSUsages.Educational);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:rnd", SaaSUsages.RnD);
        }
    }
}
