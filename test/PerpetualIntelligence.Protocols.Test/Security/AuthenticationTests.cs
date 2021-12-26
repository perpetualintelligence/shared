/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Security
{
    [TestClass]
    public class AuthenticationTests
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Authentication), 11);

            Assert.AreEqual("Bearer", Authentication.BearerAuthorizationHeader);
            Assert.AreEqual("Bearer", Authentication.BearerTokenType);
            Assert.AreEqual("urn:oneimlx:oidc:auth", Authentication.DefaultAuthenticationType);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.Session", Authentication.DefaultCheckSessionCookieName);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.Auth", Authentication.DefaultCookieAuthenticationScheme);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Trustcenter.Cors", Authentication.DefaultCorsPolicyName);
            Assert.AreEqual("PerpetualIntelligence.OneImlx.Cookie.External", Authentication.DefaultExternalCookieAuthenticationScheme);
            Assert.AreEqual("urn:oneimlx:scheme:jwt", Authentication.DefaultJwtRequestClientKeyScheme);
            Assert.AreEqual("urn:oneimlx:scheme:lidp", Authentication.DefaultLocalIdP);
            Assert.AreEqual("urn:oneimlx:scheme:signout", Authentication.DefaultSignoutScheme);
            Assert.AreEqual(10, Authentication.DefaultTimeoutSeconds);
        }
    }
}
