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
