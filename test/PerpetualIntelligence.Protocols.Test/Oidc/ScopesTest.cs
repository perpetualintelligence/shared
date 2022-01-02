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
    public class ScopesTest
    {
        [TestMethod]
        public void StandardScopesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Scopes), 12);

            Assert.AreEqual("address", Scopes.Address);
            Assert.AreEqual("urn:oneimlx:scope:app", Scopes.Application);
            Assert.AreEqual("email", Scopes.Email);
            Assert.AreEqual("offline_access", Scopes.OfflineAccess);
            Assert.AreEqual("openid", Scopes.OpenId);
            Assert.AreEqual("urn:oneimlx:scope:perm", Scopes.Permission);
            Assert.AreEqual("phone", Scopes.Phone);
            Assert.AreEqual("profile", Scopes.Profile);
            Assert.AreEqual("role", Scopes.Role);
            Assert.AreEqual("urn:oneimlx:scope:tenant", Scopes.Tenant);
            Assert.AreEqual("urn:oneimlx:scope:tlevels", Scopes.TenantLevels);
            Assert.AreEqual("urn:oneimlx:scope:api", Scopes.Api);
        }
    }
}
