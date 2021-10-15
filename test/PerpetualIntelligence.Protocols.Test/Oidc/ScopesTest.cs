// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ScopesTest
    {
        [TestMethod]
        public void StandardScopesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Scopes), 11);

            Assert.AreEqual("address", Scopes.Address);
            Assert.AreEqual("urn:pi:protocols:oidc:scope:app", Scopes.Application);
            Assert.AreEqual("email", Scopes.Email);
            Assert.AreEqual("offline_access", Scopes.OfflineAccess);
            Assert.AreEqual("openid", Scopes.OpenId);
            Assert.AreEqual("urn:pi:protocols:oidc:scope:perm", Scopes.Permission);
            Assert.AreEqual("phone", Scopes.Phone);
            Assert.AreEqual("profile", Scopes.Profile);
            Assert.AreEqual("role", Scopes.Role);
            Assert.AreEqual("urn:pi:protocols:oidc:scope:tenant", Scopes.Tenant);
            Assert.AreEqual("urn:pi:protocols:oidc:scope:api", Scopes.Api);
        }
    }
}
