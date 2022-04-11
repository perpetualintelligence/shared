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
            Assert.IsTrue(SaaSUsages.IsValid(SaaSUsages.None));
        }

        [TestMethod]
        public void SaaSUsagesTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSUsages), 5);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:org", SaaSUsages.CommercialBusiness);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:per", SaaSUsages.CommercialPersonal);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:edu", SaaSUsages.Educational);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:rnd", SaaSUsages.RnD);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:none", SaaSUsages.None);
        }
    }
}
