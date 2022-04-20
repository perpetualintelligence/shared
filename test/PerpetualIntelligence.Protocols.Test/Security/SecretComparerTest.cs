/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    [TestClass]
    public class SecretComparerTest
    {
        [TestMethod]
        public void ConstantTimeComparerIsEqualTest()
        {
            Assert.IsTrue(SecretComparer.IsEqual("", ""));
            Assert.IsFalse(SecretComparer.IsEqual("TestString", ""));
            Assert.IsFalse(SecretComparer.IsEqual("Test", "Test1"));
            Assert.IsFalse(SecretComparer.IsEqual("Test", "TesT"));
            Assert.IsTrue(SecretComparer.IsEqual("TestString", "TestString"));
        }
    }
}
