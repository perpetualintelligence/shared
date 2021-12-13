/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class LocalStorageKeysTest
    {
        [TestMethod]
        public void InternalLocalStorageKeysConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(LocalStorageKeys), 1);

            Assert.AreEqual("urn:oneimlx:lsk:isdiag", LocalStorageKeys.IsDiagnostic);
        }
    }
}
