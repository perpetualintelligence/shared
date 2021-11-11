/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
