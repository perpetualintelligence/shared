/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
