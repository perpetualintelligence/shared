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
    public class SaaSPlansTests
    {
        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSPlans), 5);

            Assert.AreEqual("urn:oneimlx:saas:community", SaaSPlans.Community);
            Assert.AreEqual("urn:oneimlx:saas:micro", SaaSPlans.Micro);
            Assert.AreEqual("urn:oneimlx:saas:smb", SaaSPlans.SMB);
            Assert.AreEqual("urn:oneimlx:saas:enterprise", SaaSPlans.Enterprise);
            Assert.AreEqual("urn:oneimlx:saas:custom", SaaSPlans.Custom);
        }
    }
}
