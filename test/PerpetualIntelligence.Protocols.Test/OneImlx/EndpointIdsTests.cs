/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class EndpointIdsTests
    {
        [TestMethod]
        public void EndpointIdsTest()
        {
            TestHelper.AssertConstantCount(typeof(EndpointIds), 12);

            Assert.AreEqual("urn:oneimlx:auth", EndpointIds.Authorize);
            Assert.AreEqual("urn:oneimlx:authcb", EndpointIds.AuthorizeCallback);
            Assert.AreEqual("urn:oneimlx:checksession", EndpointIds.CheckSession);
            Assert.AreEqual("urn:oneimlx:device", EndpointIds.DeviceAuthorization);
            Assert.AreEqual("urn:oneimlx:discovery", EndpointIds.DiscoveryConfiguration);
            Assert.AreEqual("urn:oneimlx:jwks", EndpointIds.DiscoveryWebKeys);
            Assert.AreEqual("urn:oneimlx:endsession", EndpointIds.EndSession);
            Assert.AreEqual("urn:oneimlx:endsessioncb", EndpointIds.EndSessionCallback);
            Assert.AreEqual("urn:oneimlx:introspection", EndpointIds.Introspection);
            Assert.AreEqual("urn:oneimlx:revocation", EndpointIds.Revocation);
            Assert.AreEqual("urn:oneimlx:token", EndpointIds.Token);
            Assert.AreEqual("urn:oneimlx:userinfo", EndpointIds.UserInfo);
        }
    }
}
