// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.AreEqual("urn:pi:protocol:security:csp:l3", ContentSecurityPolicies.Level3);
        }
    }
}
