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
    public class SaaSKeySourcesTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSource()
        {
            Assert.IsFalse(SaaSKeySources.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSKeySources.IsValid(SaaSKeySources.JsonFile));
        }

        [TestMethod]
        public void SaaSUsagesTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSKeySources), 1);

            Assert.AreEqual("urn:oneimlx:lic:ksource:jsonfile", SaaSKeySources.JsonFile);
        }
    }
}
