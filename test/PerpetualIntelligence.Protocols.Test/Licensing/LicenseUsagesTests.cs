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
    public class LicenseUsagesTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidlicenseUsage()
        {
            Assert.IsFalse(LicenseUsages.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(LicenseUsages.IsValid(LicenseUsages.CommercialBusiness));
            Assert.IsTrue(LicenseUsages.IsValid(LicenseUsages.CommercialPersonal));
            Assert.IsTrue(LicenseUsages.IsValid(LicenseUsages.Educational));
            Assert.IsTrue(LicenseUsages.IsValid(LicenseUsages.RnD));
            Assert.IsTrue(LicenseUsages.IsValid(LicenseUsages.None));
        }

        [TestMethod]
        public void LicenseUsagesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseUsages), 5);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:org", LicenseUsages.CommercialBusiness);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:per", LicenseUsages.CommercialPersonal);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:edu", LicenseUsages.Educational);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:rnd", LicenseUsages.RnD);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:none", LicenseUsages.None);
        }
    }
}
