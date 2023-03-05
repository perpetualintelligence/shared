/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Licensing
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

            Assert.AreEqual("urn:oneimlx:lic:usage:org", LicenseUsages.CommercialBusiness);
            Assert.AreEqual("urn:oneimlx:lic:usage:per", LicenseUsages.CommercialPersonal);
            Assert.AreEqual("urn:oneimlx:lic:usage:edu", LicenseUsages.Educational);
            Assert.AreEqual("urn:oneimlx:lic:usage:rnd", LicenseUsages.RnD);

            Assert.AreEqual("urn:oneimlx:lic:usage:none", LicenseUsages.None);
        }
    }
}
