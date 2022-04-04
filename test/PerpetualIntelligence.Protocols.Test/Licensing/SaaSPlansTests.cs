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
            TestHelper.AssertConstantCount(typeof(SaaSPlans), 6);

            Assert.AreEqual("pi-saas-plans-community", SaaSPlans.Community);
            Assert.AreEqual("pi-saas-plans-micro", SaaSPlans.Micro);
            Assert.AreEqual("pi-saas-plans-smb", SaaSPlans.SMB);
            Assert.AreEqual("pi-saas-plans-enterprise", SaaSPlans.Enterprise);
            Assert.AreEqual("pi-saas-plans-custom", SaaSPlans.Custom);
            Assert.AreEqual("pi-saas-plans-isv", SaaSPlans.ISV);
        }
    }
}
