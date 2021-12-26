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
   public class PromptsTest
    {
        [TestMethod]
        public void PromptModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Prompts), 4);

            Assert.AreEqual("consent", Prompts.Consent);
            Assert.AreEqual("login", Prompts.Login);
            Assert.AreEqual("none", Prompts.None);
            Assert.AreEqual("select_account", Prompts.SelectAccount);
        }
    }
}
