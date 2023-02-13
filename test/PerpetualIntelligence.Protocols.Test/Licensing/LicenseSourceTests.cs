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
    public class LicenseSourceTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSource()
        {
            Assert.IsFalse(LicenseSources.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(LicenseSources.IsValid(LicenseSources.JsonFile));
        }

        [TestMethod]
        public void LicenseKeySourcesConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseSources), 1);

            Assert.AreEqual("urn:oneimlx:lic:source:jsonfile", LicenseSources.JsonFile);
        }
    }
}
