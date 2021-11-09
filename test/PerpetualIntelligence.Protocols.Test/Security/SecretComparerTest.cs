/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    [TestClass]
    public class SecretComparerTest
    {
        [TestMethod]
        public void ConstantTimeComparerISEqualTest()
        {
            Assert.IsTrue(SecretComparer.IsEqual("", ""));
            Assert.IsFalse(SecretComparer.IsEqual("TestString", ""));
            Assert.IsFalse(SecretComparer.IsEqual("Test", "Test1"));
            Assert.IsFalse(SecretComparer.IsEqual("Test", "TesT"));
            Assert.IsTrue(SecretComparer.IsEqual("TestString", "TestString"));
        }
    }
}
