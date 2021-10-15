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
            Assert.AreEqual("introspection", EndpointNames.Introspection);
            Assert.AreEqual("revocation", EndpointNames.Revocation);
            Assert.AreEqual("token", EndpointNames.Token);
            Assert.AreEqual("user_info", EndpointNames.UserInfo);
        }
    }
}
