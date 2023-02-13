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
    public class LicenseKeySourceTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSource()
        {
            Assert.IsFalse(LicenseKeySource.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(LicenseKeySource.IsValid(LicenseKeySource.JsonFile));
        }

        [TestMethod]
        public void LicenseKeySourcesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseKeySource), 1);

            Assert.AreEqual("urn:oneimlx:lic:ksource:jsonfile", LicenseKeySource.JsonFile);
        }
    }
}
