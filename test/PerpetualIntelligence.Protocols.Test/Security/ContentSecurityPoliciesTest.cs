/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Security
{
    [TestClass]
    public class ContentSecurityPoliciesTest
    {
        [TestMethod]
        public void ContentSecurityPoliciesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ContentSecurityPolicies), 3);

            Assert.AreEqual("urn:oneimlx:security:csp:l1", ContentSecurityPolicies.Level1);
            Assert.AreEqual("urn:oneimlx:security:csp:l2", ContentSecurityPolicies.Level2);
#pragma warning disable CS0618 // Type or member is obsolete
            Assert.AreEqual("urn:oneimlx:security:csp:l3", ContentSecurityPolicies.Level3);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
