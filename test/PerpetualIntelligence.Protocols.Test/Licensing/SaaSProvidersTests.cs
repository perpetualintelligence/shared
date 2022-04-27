/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Licensing
{
    public class SaaSProvidersTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSUsage()
        {
            Assert.IsFalse(SaaSProviders.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSProviders.IsValid(SaaSProviders.PerpetualIntelligence));
        }

        [TestMethod]
        public void SaaSProvidersTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSProviders), 1);

            Assert.AreEqual("urn:oneimlx:lic:saaspvdr:pi", SaaSProviders.PerpetualIntelligence);
        }
    }
}
