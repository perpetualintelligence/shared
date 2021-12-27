// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    [TestClass]
    public class X509StoreNameTest
    {
        [TestMethod]
        public void FindByTypessTest()
        {
            FindByType name = new FindByType(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, System.Security.Cryptography.X509Certificates.StoreName.My);

            Assert.AreEqual(System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint, name.Thumbprint.FindType);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName, name.SubjectDistinguishedName.FindType);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.X509FindType.FindBySerialNumber, name.SerialNumber.FindType);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName, name.IssuerName.FindType);
        }

        [TestMethod]
        public void FindTypeLocationNameMatchTest()
        {
            FindByType name = new FindByType(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, System.Security.Cryptography.X509Certificates.StoreName.My);

            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, name.Thumbprint.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, name.Thumbprint.Name);

            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, name.SubjectDistinguishedName.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, name.SubjectDistinguishedName.Name);

            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, name.SerialNumber.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, name.SerialNumber.Name);

            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, name.IssuerName.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, name.IssuerName.Name);
        }
    }
}
