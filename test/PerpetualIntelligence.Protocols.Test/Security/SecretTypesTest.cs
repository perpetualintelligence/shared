/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    [TestClass]
    public class SecretTypesTest
    {
        [TestMethod]
        public void SecretTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(SecretTypes), 9);

            Assert.AreEqual("urn:oneimlx:security:secret:jwk", SecretTypes.JsonWebKey);
            Assert.AreEqual("urn:ietf:params:oauth:client-assertion-type:jwt-bearer", SecretTypes.JwtBearer);
            Assert.AreEqual("urn:oneimlx:security:secret:none", SecretTypes.None);
            Assert.AreEqual("urn:oneimlx:security:secret:pln", SecretTypes.Plain);
            Assert.AreEqual("urn:oneimlx:security:secret:sha", SecretTypes.Sha);
            Assert.AreEqual("urn:oneimlx:security:secret:x509b64", SecretTypes.X509Base64);
            Assert.AreEqual("urn:oneimlx:security:secret:x509mtls", SecretTypes.X509Mtls);
            Assert.AreEqual("urn:oneimlx:security:secret:x509sub", SecretTypes.X509Subject);
            Assert.AreEqual("urn:oneimlx:security:secret:x509tb", SecretTypes.X509Thumbprint);
        }
    }
}
