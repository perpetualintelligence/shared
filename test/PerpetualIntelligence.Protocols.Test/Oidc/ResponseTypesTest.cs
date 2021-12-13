// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ResponseTypesTest
    {
        [TestMethod]
        public void ResponseTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ResponseTypes), 7);

            Assert.AreEqual("code", ResponseTypes.Code);
            Assert.AreEqual("code id_token", ResponseTypes.CodeIdToken);
            Assert.AreEqual("code id_token token", ResponseTypes.CodeIdTokenToken);
            Assert.AreEqual("code token", ResponseTypes.CodeToken);
            Assert.AreEqual("id_token", ResponseTypes.IdToken);
            Assert.AreEqual("id_token token", ResponseTypes.IdTokenToken);
            Assert.AreEqual("token", ResponseTypes.Token);
        }
    }
}
