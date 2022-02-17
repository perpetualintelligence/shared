/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.SaaS
{
    [TestClass]
    public class PricingPlansTests
    {
        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(PricingPlans), 5);

            Assert.AreEqual("urn:oneimlx:saas:community", PricingPlans.Community);
            Assert.AreEqual("urn:oneimlx:saas:micro", PricingPlans.Micro);
            Assert.AreEqual("urn:oneimlx:saas:smb", PricingPlans.SMB);
            Assert.AreEqual("urn:oneimlx:saas:enterprise", PricingPlans.Enterprise);
            Assert.AreEqual("urn:oneimlx:saas:custom", PricingPlans.Custom);
        }
    }
}
