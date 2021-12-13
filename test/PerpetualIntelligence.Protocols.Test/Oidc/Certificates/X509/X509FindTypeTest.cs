// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    [TestClass]
    public class X509FindTypeTest
    {
        [TestMethod]
        public void FindByTypeTest()
        {
            X509FindType findType = new X509FindType(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, System.Security.Cryptography.X509Certificates.StoreName.My, System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, findType.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, findType.Name);
        }
    }
}
