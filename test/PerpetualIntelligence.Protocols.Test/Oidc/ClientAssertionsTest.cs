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
    public class ClientAssertionsTest
    {
        [TestMethod]
        public void ClientAssertionTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ClientAssertions), 2);

            Assert.AreEqual("urn:ietf:params:oauth:client-assertion-type:jwt-bearer", ClientAssertions.JwtBearer);
            Assert.AreEqual("urn:ietf:params:oauth:client-assertion-type:saml2-bearer", ClientAssertions.SamlBearer);
        }
    }
}
