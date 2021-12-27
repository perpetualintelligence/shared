/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class EndpointIdsTests
    {
        [TestMethod]
        public void EndpointIdsTest()
        {
            TestHelper.AssertConstantCount(typeof(EndpointIds), 10);

            Assert.AreEqual("urn:oneimlx:auth", EndpointIds.Authorize);
            Assert.AreEqual("urn:oneimlx:checksession", EndpointIds.CheckSession);
            Assert.AreEqual("urn:oneimlx:device", EndpointIds.DeviceAuthorization);
            Assert.AreEqual("urn:oneimlx:discovery", EndpointIds.Discovery);
            Assert.AreEqual("urn:oneimlx:jwks", EndpointIds.Jwks);
            Assert.AreEqual("urn:oneimlx:endsession", EndpointIds.EndSession);
            Assert.AreEqual("urn:oneimlx:introspect", EndpointIds.Introspect);
            Assert.AreEqual("urn:oneimlx:revoke", EndpointIds.Revoke);
            Assert.AreEqual("urn:oneimlx:token", EndpointIds.Token);
            Assert.AreEqual("urn:oneimlx:userinfo", EndpointIds.UserInfo);
        }
    }
}
