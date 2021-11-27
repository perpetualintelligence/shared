/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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

            Assert.AreEqual("urn:pi:protocol:security:csp:l1", ContentSecurityPolicies.Level1);
            Assert.AreEqual("urn:pi:protocol:security:csp:l2", ContentSecurityPolicies.Level2);
#pragma warning disable CS0618 // Type or member is obsolete
            Assert.AreEqual("urn:pi:protocol:security:csp:l3", ContentSecurityPolicies.Level3);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
