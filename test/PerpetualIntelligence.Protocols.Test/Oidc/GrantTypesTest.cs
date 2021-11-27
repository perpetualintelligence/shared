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
    public class GrantTypesTest
    {
        [TestMethod]
        public void GrantTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(GrantTypes), 10);

            Assert.AreEqual("authorization_code", GrantTypes.AuthorizationCode);
            Assert.AreEqual("client_credentials", GrantTypes.ClientCredentials);
            Assert.AreEqual("urn:ietf:params:oauth:grant-type:device_code", GrantTypes.DeviceCode);
#pragma warning disable CS0618 // Type or member is obsolete
            Assert.AreEqual("implicit", GrantTypes.Implicit);
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual("hybrid", GrantTypes.Hybrid);
            Assert.AreEqual("urn:ietf:params:oauth:grant-type:jwt-bearer", GrantTypes.JwtBearer);
            Assert.AreEqual("password", GrantTypes.ResourceOwnerPassword);
            Assert.AreEqual("refresh_token", GrantTypes.RefreshToken);
            Assert.AreEqual("urn:ietf:params:oauth:grant-type:saml2-bearer", GrantTypes.Saml2Bearer);
            Assert.AreEqual("urn:ietf:params:oauth:grant-type:token-exchange", GrantTypes.TokenExchange);
        }
    }
}
