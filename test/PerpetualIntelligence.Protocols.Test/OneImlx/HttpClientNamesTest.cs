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
    public class HttpClientNamesTest
    {
        [TestMethod]
        public void HttpClientNamesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(HttpClientNames), 4);

            Assert.AreEqual("urn:oneimlx:http:capp", HttpClientNames.ClientApp);
            Assert.AreEqual("urn:oneimlx:http:apisvr", HttpClientNames.ApiServer);
            Assert.AreEqual("urn:oneimlx:http:jwturis", HttpClientNames.JwtRequestUri);
            Assert.AreEqual("urn:oneimlx:http:bclogout", HttpClientNames.BackChannelLogout);
        }
    }
}
