/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.Community));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.Micro));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.SMB));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.Enterprise));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.Custom));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.ISV));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.ISVU));
            Assert.IsTrue(LicensePlans.IsValid(LicensePlans.None));
        }

        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidlicensePlans()
        {
            Assert.IsFalse(LicensePlans.IsValid("invalid"));
        }

        [TestMethod]
        public void LicensePlansConstTest()
        {
            TestHelper.AssertConstantCount(typeof(LicensePlans), 8);

            Assert.AreEqual("urn:oneimlx:lic:plan:community", LicensePlans.Community);
            Assert.AreEqual("urn:oneimlx:lic:plan:micro", LicensePlans.Micro);
            Assert.AreEqual("urn:oneimlx:lic:plan:smb", LicensePlans.SMB);
            Assert.AreEqual("urn:oneimlx:lic:plan:enterprise", LicensePlans.Enterprise);
            Assert.AreEqual("urn:oneimlx:lic:plan:custom", LicensePlans.Custom);
            Assert.AreEqual("urn:oneimlx:lic:plan:isv", LicensePlans.ISV);
            Assert.AreEqual("urn:oneimlx:lic:plan:isvu", LicensePlans.ISVU);

            Assert.AreEqual("urn:oneimlx:lic:plan:none", LicensePlans.None);
        }
    }
}
