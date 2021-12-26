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
            TestHelper.AssertConstantCount(typeof(Constants), 9);

            Assert.AreEqual("urn:oneimlx:cli", Constants.Cli);
            Assert.AreEqual("OAuth2.0", Constants.OAuth2);
            Assert.AreEqual("urn:oneimlx", Constants.OneImlx);
            Assert.AreEqual("urn:oneimlx:oauth2", Constants.OneImlxOAuth2);
            Assert.AreEqual("urn:oneimlx:oidc", Constants.OneImlxOpenIDConnect);
            Assert.AreEqual("PerpetualIntelligence.OneImlx", Constants.OneImlxOrg);
            Assert.AreEqual("urn:oneimlx:wsfed", Constants.OneImlxWebServicesFederation);
            Assert.AreEqual("oidc", Constants.OpenIDConnect);
            Assert.AreEqual("wsfed", Constants.WebServicesFederation);
        }
    }
}
