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
    public class LicenseKeySourcesTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSource()
        {
            Assert.IsFalse(LicenseKeySources.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(LicenseKeySources.IsValid(LicenseKeySources.JsonFile));
        }

        [TestMethod]
        public void LicenseKeySourcesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseKeySources), 1);

            Assert.AreEqual("urn:oneimlx:lic:ksource:jsonfile", LicenseKeySources.JsonFile);
        }
    }
}
