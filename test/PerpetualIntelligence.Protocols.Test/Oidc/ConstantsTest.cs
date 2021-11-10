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
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Constants), 13);

            Assert.AreEqual("urn:oneimlx:oidc:auth", Constants.AuthenticationType);
            Assert.AreEqual("Bearer", Constants.AuthorizationHeaderBearer);
            Assert.AreEqual("Bearer", Constants.BearerTokenType);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cors", Constants.CorsPolicyName);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.Session", Constants.DefaultCheckSessionCookieName);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.Auth", Constants.DefaultCookieAuthenticationScheme);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.External", Constants.DefaultExternalCookieAuthenticationScheme);
            Assert.AreEqual("urn:oneimlx:oidc:scheme:jwt", Constants.DefaultJwtRequestClientKey);
            Assert.AreEqual("urn:oneimlx:oidc:scheme:signout", Constants.DefaultSignoutScheme);
            Assert.AreEqual("urn:oneimlx:oidc:idp:local", Constants.LocalIdP);
            Assert.AreEqual("logout_token", Constants.LogoutToken);
            Assert.AreEqual("oidc", Constants.OpenIDConnect);
            Assert.AreEqual(10, Constants.DefaultTimeoutSeconds);
        }
    }
}
