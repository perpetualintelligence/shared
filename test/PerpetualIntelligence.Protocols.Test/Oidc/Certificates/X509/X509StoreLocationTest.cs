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
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, FindByStore.CurrentUser.Location);
        }

        [TestMethod]
        public void LocalMachineLocationTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine, FindByStore.LocalMachine.Location);
        }


        [TestMethod]
        public void StoreNamesTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, FindByStore.CurrentUser.My.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.AddressBook, FindByStore.CurrentUser.AddressBook.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople, FindByStore.CurrentUser.TrustedPeople.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPublisher, FindByStore.CurrentUser.TrustedPublisher.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.CertificateAuthority, FindByStore.CurrentUser.CertificateAuthority.Name);            
        }

        [TestMethod]
        public void CurrentUserLocationNameMatchTest()
        {
            Assert.AreEqual(FindByStore.CurrentUser.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindByStore.CurrentUser.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindByStore.CurrentUser.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindByStore.CurrentUser.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindByStore.CurrentUser.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
        }


        [TestMethod]
        public void LocalMachineLocationNameMatchTest()
        {
            Assert.AreEqual(FindByStore.LocalMachine.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindByStore.LocalMachine.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindByStore.LocalMachine.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindByStore.LocalMachine.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindByStore.LocalMachine.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
        }
    }
}
