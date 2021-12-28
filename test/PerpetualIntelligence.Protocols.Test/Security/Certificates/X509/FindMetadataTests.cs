/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Certificates.X509
{
    [TestClass]
    public class FindMetadataTests
    {
        [TestMethod]
        public void FindByTypeTest()
        {
            FindMetadata findType = new FindMetadata(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, System.Security.Cryptography.X509Certificates.StoreName.My, System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser, findType.Location);
            Assert.AreEqual(System.Security.Cryptography.X509Certificates.StoreName.My, findType.Name);
        }
    }
}
