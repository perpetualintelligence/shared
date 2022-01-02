/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
