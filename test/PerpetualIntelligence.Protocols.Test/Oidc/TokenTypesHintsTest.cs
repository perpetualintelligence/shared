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
    public class TokenTypesHintsTest
    {
        [TestMethod]
        public void TokenTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(TokenTypeHints), 3);

            Assert.AreEqual("access_token", TokenTypeHints.AccessToken);
            Assert.AreEqual("refresh_token", TokenTypeHints.RefreshToken);
            Assert.AreEqual("id_token", TokenTypeHints.IdToken);
        }
    }
}
