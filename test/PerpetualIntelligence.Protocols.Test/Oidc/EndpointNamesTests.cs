/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

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
