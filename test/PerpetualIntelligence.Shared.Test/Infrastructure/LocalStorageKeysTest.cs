/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class LocalStorageKeysTest
    {
        [TestMethod]
        public void InternalLocalStorageKeysConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(LocalStorageKeys), 3);

            Assert.AreEqual("urn:oneimlx:lsk:isdiag", LocalStorageKeys.IsDiagnostic);
            Assert.AreEqual("urn:oneimlx:lsk:layer", LocalStorageKeys.LayerLuminance);
            Assert.AreEqual("urn:oneimlx:lsk:isl10prefixed", LocalStorageKeys.IsLocalizationPrefixed);
        }
    }
}
