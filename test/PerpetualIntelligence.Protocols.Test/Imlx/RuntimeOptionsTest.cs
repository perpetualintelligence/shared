/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class RuntimeOptionsTest
    {
        [TestMethod]
        public void OptionsTest()
        {
            // If you add a new configure, make sure you test its name and value below.
            TestHelper.AssertConstantCount(typeof(RuntimeOptions), 10);

            Assert.AreEqual("PerpetualIntelligence:Runtime:Endpoints:ApiServerLocalhostEndpoint", RuntimeOptions.ApiServerLocalhostEndpoint);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Endpoints:ApiServerProductionEndpoint", RuntimeOptions.ApiServerProductionEndpoint);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Endpoints:ClientAppLocalhostEndpoint", RuntimeOptions.ClientAppLocalhostEndpoint);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Endpoints:ClientAppProductionEndpoint", RuntimeOptions.ClientAppProductionEndpoint);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Data:CheckEntityProperties", RuntimeOptions.CheckEntityProperties);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Data:CheckStore", RuntimeOptions.CheckStore);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Endpoints:Host", RuntimeOptions.EndpointsHost);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Payments:Mode", RuntimeOptions.PaymentMode);
            Assert.AreEqual("PerpetualIntelligence:Runtime:Data:UseTestData", RuntimeOptions.UseTestData);
        }
    }
}
