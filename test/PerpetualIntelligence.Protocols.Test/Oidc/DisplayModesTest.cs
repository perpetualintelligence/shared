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
   public class DisplayModesTest
    {
        [TestMethod]
        public void DisplayModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(DisplayModes), 4);

            Assert.AreEqual("page", DisplayModes.Page);
            Assert.AreEqual("popup", DisplayModes.Popup); 
            Assert.AreEqual("touch", DisplayModes.Touch);
            Assert.AreEqual("wap", DisplayModes.Wap);
        }
    }
}
