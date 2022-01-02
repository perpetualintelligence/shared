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
    public class OrgConstantsTest
    {
        [TestMethod]
        public void ConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(OrgConstants), 5);

            Assert.AreEqual("Perpetual Intelligence L.L.C.", OrgConstants.FullName);
            Assert.AreEqual("https://github.com/perpetualintelligence", OrgConstants.GitHub);
            Assert.AreEqual("https://github.com/perpetualintelligence/terms/blob/main/logo/icon.png", OrgConstants.LogoUrl);
            Assert.AreEqual("https://terms.perpetualintelligence.com/articles/intro.html", OrgConstants.Policies);
            Assert.AreEqual("Perpetual Intelligence", OrgConstants.ShortName);
        }
    }
}
