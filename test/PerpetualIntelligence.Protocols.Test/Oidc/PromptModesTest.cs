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
   public class PromptModesTest
    {
        [TestMethod]
        public void PromptModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(PromptModes), 4);

            Assert.AreEqual("consent", PromptModes.Consent);
            Assert.AreEqual("login", PromptModes.Login);
            Assert.AreEqual("none", PromptModes.None);
            Assert.AreEqual("select_account", PromptModes.SelectAccount);
        }
    }
}
