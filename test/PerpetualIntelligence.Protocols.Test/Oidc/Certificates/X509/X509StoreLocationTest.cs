// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    [TestClass]
    public class X509StoreLocationTest
    {
        [TestMethod]
        public void CurrentUserLocationTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, X509StoreLocation.CurrentUser.Location);
        }

        [TestMethod]
        public void LocalMachineLocationTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine, X509StoreLocation.LocalMachine.Location);
        }


        [TestMethod]
        public void StoreNamesTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, X509StoreLocation.CurrentUser.My.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.AddressBook, X509StoreLocation.CurrentUser.AddressBook.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople, X509StoreLocation.CurrentUser.TrustedPeople.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPublisher, X509StoreLocation.CurrentUser.TrustedPublisher.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.CertificateAuthority, X509StoreLocation.CurrentUser.CertificateAuthority.Name);            
        }

        [TestMethod]
        public void CurrentUserLocationNameMatchTest()
        {
            Assert.AreEqual(X509StoreLocation.CurrentUser.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(X509StoreLocation.CurrentUser.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(X509StoreLocation.CurrentUser.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(X509StoreLocation.CurrentUser.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(X509StoreLocation.CurrentUser.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
        }


        [TestMethod]
        public void LocalMachineLocationNameMatchTest()
        {
            Assert.AreEqual(X509StoreLocation.LocalMachine.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(X509StoreLocation.LocalMachine.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(X509StoreLocation.LocalMachine.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(X509StoreLocation.LocalMachine.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(X509StoreLocation.LocalMachine.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
        }
    }
}
