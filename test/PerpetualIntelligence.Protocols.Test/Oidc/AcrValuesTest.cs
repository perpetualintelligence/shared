/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
