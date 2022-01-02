/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

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
