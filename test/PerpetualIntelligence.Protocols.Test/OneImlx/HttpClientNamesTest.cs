/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
