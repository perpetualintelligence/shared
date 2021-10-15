/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class EndpointIdsTests
    {
        [TestMethod]
        public void EndpointIdsTest()
        {
            TestHelper.AssertConstantCount(typeof(EndpointIds), 12);

            Assert.AreEqual("urn:pi:protocols:imlx:auth", EndpointIds.Authorize);
            Assert.AreEqual("urn:pi:protocols:imlx:authcb", EndpointIds.AuthorizeCallback);
            Assert.AreEqual("urn:pi:protocols:imlx:check", EndpointIds.CheckSession);
            Assert.AreEqual("urn:pi:protocols:imlx:device", EndpointIds.DeviceAuthorization);
            Assert.AreEqual("urn:pi:protocols:imlx:discovery", EndpointIds.DiscoveryConfiguration);
            Assert.AreEqual("urn:pi:protocols:imlx:jwks", EndpointIds.DiscoveryWebKeys);
            Assert.AreEqual("urn:pi:protocols:imlx:end", EndpointIds.EndSession);
            Assert.AreEqual("urn:pi:protocols:imlx:endcb", EndpointIds.EndSessionCallback);
            Assert.AreEqual("urn:pi:protocols:imlx:introspection", EndpointIds.Introspection);
            Assert.AreEqual("urn:pi:protocols:imlx:revocation", EndpointIds.Revocation);
            Assert.AreEqual("urn:pi:protocols:imlx:token", EndpointIds.Token);
            Assert.AreEqual("urn:pi:protocols:imlx:userinfo", EndpointIds.UserInfo);
        }
    }
}
