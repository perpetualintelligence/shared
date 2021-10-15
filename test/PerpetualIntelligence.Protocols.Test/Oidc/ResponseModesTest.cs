// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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
   public class ResponseModesTest
    {
        [TestMethod]
        public void ResponseModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ResponseModes), 3);

            Assert.AreEqual("form_post", ResponseModes.FormPost);
            Assert.AreEqual("fragment", ResponseModes.Fragment);
            Assert.AreEqual("query", ResponseModes.Query);
        }
    }
}
