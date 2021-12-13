/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class AccessTokenTypeTest
    {
        [TestMethod]
        public void AccessTokenTypeTestConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(AccessTokens), 2);

            Assert.AreEqual("urn:oneimlx:oidc:at:jwt", AccessTokens.Jwt);
            Assert.AreEqual("urn:oneimlx:oidc:at:opaque", AccessTokens.Opaque);
        }
    }
}
