// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
   public class HttpClientNamesTest
    {
        [TestMethod]
        public void HttpClientNamesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(HttpClientNames), 4);

            Assert.AreEqual("pi:protocols:imlx:http:capp", HttpClientNames.ClientApp);
            Assert.AreEqual("pi:protocols:imlx:http:apisvr", HttpClientNames.ApiServer);
            Assert.AreEqual("pi:protocols:imlx:http:jwturis", HttpClientNames.JwtRequestUri);
            Assert.AreEqual("pi:protocols:imlx:http:bclogout", HttpClientNames.BackChannelLogout);
        }
    }
}
