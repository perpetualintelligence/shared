/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Licensing
{
    public class LicenseProvidersTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidlicenseUsage()
        {
            Assert.IsFalse(LicenseProviders.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(LicenseProviders.IsValid(LicenseProviders.PerpetualIntelligence));
        }

        [TestMethod]
        public void LicenseProvidersConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicenseProviders), 1);

            Assert.AreEqual("urn:oneimlx:lic:pvdr:pi", LicenseProviders.PerpetualIntelligence);
        }
    }
}
