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
    public class TokensTest
    {
        [TestMethod]
        public void TokensConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Tokens), 6);

            Assert.AreEqual("urn:ietf:params:oauth:token-type:access_token", Tokens.AccessToken);
            Assert.AreEqual("urn:ietf:params:oauth:token-type:id_token", Tokens.IdToken);
            Assert.AreEqual("urn:ietf:params:oauth:token-type:jwt", Tokens.Jwt);
            Assert.AreEqual("urn:ietf:params:oauth:token-type:refresh_token", Tokens.RefreshToken);
            Assert.AreEqual("urn:ietf:params:oauth:token-type:saml1", Tokens.Saml1);
            Assert.AreEqual("urn:ietf:params:oauth:token-type:saml2", Tokens.Saml2);
        }
    }
}
