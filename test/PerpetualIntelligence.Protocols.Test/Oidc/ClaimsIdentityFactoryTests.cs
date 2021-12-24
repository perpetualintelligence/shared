/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ClaimsIdentityFactoryTests
    {
        [TestMethod]
        public void FromAnonymityTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsIdentity", ClaimsIdentityFactory.FromAnonymity().ToString());
        }

        [TestMethod]
        public void FromCertificateTest()
        {
        }

        [TestMethod]
        public void FromClaimsTest()
        {
        }
    }
}
