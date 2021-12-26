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
   public class DisplaysTest
    {
        [TestMethod]
        public void DisplayModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Displays), 4);

            Assert.AreEqual("page", Displays.Page);
            Assert.AreEqual("popup", Displays.Popup); 
            Assert.AreEqual("touch", Displays.Touch);
            Assert.AreEqual("wap", Displays.Wap);
        }
    }
}
