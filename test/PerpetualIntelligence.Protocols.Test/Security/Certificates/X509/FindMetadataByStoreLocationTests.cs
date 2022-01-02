/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    [TestClass]
    public class FindMetadataByStoreLocationTests
    {
        [TestMethod]
        public void CurrentUserLocationNameMatchTest()
        {
            Assert.AreEqual(FindMetadataByStore.CurrentUser.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindMetadataByStore.CurrentUser.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindMetadataByStore.CurrentUser.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindMetadataByStore.CurrentUser.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
            Assert.AreEqual(FindMetadataByStore.CurrentUser.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
        }

        [TestMethod]
        public void CurrentUserLocationTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, FindMetadataByStore.CurrentUser.Location);
        }

        [TestMethod]
        public void LocalMachineLocationNameMatchTest()
        {
            Assert.AreEqual(FindMetadataByStore.LocalMachine.My.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindMetadataByStore.LocalMachine.AddressBook.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindMetadataByStore.LocalMachine.TrustedPeople.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindMetadataByStore.LocalMachine.TrustedPublisher.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
            Assert.AreEqual(FindMetadataByStore.LocalMachine.CertificateAuthority.Location, System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
        }

        [TestMethod]
        public void LocalMachineLocationTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine, FindMetadataByStore.LocalMachine.Location);
        }

        [TestMethod]
        public void StoreNamesTest()
        {
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, FindMetadataByStore.CurrentUser.My.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.AddressBook, FindMetadataByStore.CurrentUser.AddressBook.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople, FindMetadataByStore.CurrentUser.TrustedPeople.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.TrustedPublisher, FindMetadataByStore.CurrentUser.TrustedPublisher.Name);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.CertificateAuthority, FindMetadataByStore.CurrentUser.CertificateAuthority.Name);
        }
    }
}
