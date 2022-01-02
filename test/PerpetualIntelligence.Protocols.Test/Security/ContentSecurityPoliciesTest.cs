/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
