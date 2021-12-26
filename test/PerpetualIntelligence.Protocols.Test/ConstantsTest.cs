/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols
{
    [TestClass]
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Constants), 10);

            Assert.AreEqual("urn:oneimlx:cli", Constants.Cli);
            Assert.AreEqual("OAuth2.0", Constants.OAuth2);
            Assert.AreEqual("urn:oneimlx", Constants.OneImlxUrn);
            Assert.AreEqual("urn:oneimlx:oauth2", Constants.OneImlxOAuth2Urn);
            Assert.AreEqual("urn:oneimlx:oidc", Constants.OneImlxOpenIDConnectUrn);
            Assert.AreEqual("PerpetualIntelligence.OneImlx", Constants.OneImlxOrg);
            Assert.AreEqual("urn:oneimlx:wsfed", Constants.OneImlxWebServicesFederation);
            Assert.AreEqual("oidc", Constants.OpenIDConnect);
            Assert.AreEqual("oneimlx", Constants.OneImlx);
            Assert.AreEqual("wsfed", Constants.WebServicesFederation);
        }
    }
}
