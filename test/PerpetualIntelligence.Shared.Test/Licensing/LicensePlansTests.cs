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
    public class LicensePlansTests
    {
        [TestMethod]
        public void IsValidShouldReturnTrueForValidlicensePlans()
        {
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.Demo));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.Micro));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.SMB));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.Enterprise));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.OnPremise));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.Unlimited));
            Assert.IsTrue(LicensePlans.IsValidPiCliPlan(LicensePlans.Custom));
        }

        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidlicensePlans()
        {
            Assert.IsFalse(LicensePlans.IsValidPiCliPlan("invalid"));
        }

        [TestMethod]
        public void LicensePlansConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicensePlans), 8);

            Assert.AreEqual("urn:oneimlx:lic:plan:demo", LicensePlans.Demo);
            Assert.AreEqual("urn:oneimlx:lic:plan:micro", LicensePlans.Micro);
            Assert.AreEqual("urn:oneimlx:lic:plan:smb", LicensePlans.SMB);
            Assert.AreEqual("urn:oneimlx:lic:plan:enterprise", LicensePlans.Enterprise);
            Assert.AreEqual("urn:oneimlx:lic:plan:onprem", LicensePlans.OnPremise);
            Assert.AreEqual("urn:oneimlx:lic:plan:unlimited", LicensePlans.Unlimited);
            Assert.AreEqual("urn:oneimlx:lic:plan:custom", LicensePlans.Custom);
        }
    }
}