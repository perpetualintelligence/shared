/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class EndpointNamesTests
    {
        [TestMethod]
        public void EndpointNamesTest()
        {
            TestHelper.AssertConstantCount(typeof(EndpointNames), 9);

            Assert.AreEqual("authorize", EndpointNames.Authorize);
            Assert.AreEqual("check_session", EndpointNames.CheckSession);
            Assert.AreEqual("device_authorization", EndpointNames.DeviceAuthorization);
            Assert.AreEqual("discovery", EndpointNames.Discovery);
            Assert.AreEqual("end_session", EndpointNames.EndSession);
            Assert.AreEqual("introspect", EndpointNames.Introspect);
            Assert.AreEqual("revoke", EndpointNames.Revoke);
            Assert.AreEqual("token", EndpointNames.Token);
            Assert.AreEqual("user_info", EndpointNames.UserInfo);
        }
    }
}
