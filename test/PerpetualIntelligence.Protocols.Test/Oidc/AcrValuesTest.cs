// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class AcrValuesTest
    {
        [TestMethod]
        public void AcrValuesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(AcrValues), 7);

            Assert.AreEqual("urn:oneimlx:oidc:acr:achrgs", AcrValues.AllowedChargeables);
            Assert.AreEqual("urn:oneimlx:oidc:acr:idp", AcrValues.Idp);
            Assert.AreEqual("urn:oneimlx:oidc:acr:schrgs", AcrValues.SubscribedChargeables);
            Assert.AreEqual("urn:oneimlx:oidc:acr:tenant", AcrValues.Tenant);
            Assert.AreEqual("urn:oneimlx:oidc:acr:account", AcrValues.Account);
            Assert.AreEqual("urn:oneimlx:oidc:acr:org", AcrValues.Organization);
            Assert.AreEqual("urn:oneimlx:oidc:acr:dept", AcrValues.Department);
        }
    }
}
