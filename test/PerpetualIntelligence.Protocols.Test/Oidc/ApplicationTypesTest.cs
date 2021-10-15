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
   public class ApplicationTypesTest
    {
        [TestMethod]
        public void ApplicationTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Applications), 3);

            Assert.AreEqual("native", Applications.Native);
            Assert.AreEqual("mobile", Applications.Mobile);
            Assert.AreEqual("web", Applications.Web);
        }
    }
}
