/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class LocalStorageKeysTest
    {
        [TestMethod]
        public void InternalLocalStorageKeysConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(LocalStorageKeys), 1);

            Assert.AreEqual("urn:pi:protocols:imlx:lsk:isdiag", LocalStorageKeys.IsDiagnostic);
        }
    }
}
