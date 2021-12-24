/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class AcrValuesTest
    {
        [TestMethod]
        public void AcrValuesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(AcrValues), 9);

            Assert.AreEqual("urn:oneimlx:oidc:acr:achrgs", AcrValues.AllowedChargeables);
            Assert.AreEqual("urn:oneimlx:oidc:acr:idp", AcrValues.Idp);
            Assert.AreEqual("urn:oneimlx:oidc:acr:schrgs", AcrValues.SubscribedChargeables);

            Assert.AreEqual("urn:oneimlx:oidc:acr:tenant", AcrValues.Tenant);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tl1", AcrValues.TenantLevel1);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tl2", AcrValues.TenantLevel2);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tl3", AcrValues.TenantLevel3);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tl4", AcrValues.TenantLevel4);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tl5", AcrValues.TenantLevel5);
        }
    }
}
