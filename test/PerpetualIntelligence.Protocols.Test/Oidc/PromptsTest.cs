/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

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
