/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Security
{
    [TestClass]
    public class HexSaltGeneratorTests
    {
        [TestMethod]
        public void NewSaltIs32WithNoDashTest()
        {
            string salt = HexSaltGenerator.NewSalt();

            Assert.IsNotNull(salt);
            Assert.IsFalse(salt.Contains('-'));

            // Salt is a Hex code. For 32 bits we have 64 chars Default is 32
            Assert.AreEqual(64, salt.Length);
        }

        [TestMethod]
        public void NewSaltLenghtHasDashTest()
        {
            string salt = HexSaltGenerator.NewSalt(32, strip: false);

            Assert.IsNotNull(salt);
            Assert.IsTrue(salt.Contains('-'));

            // Salt is a Hex code for 32 bits we have 64 chars plus dahses
            Assert.AreEqual(95, salt.Length);
        }

        [TestMethod]
        public void NewSaltLengthDoesNotHaveDashTest()
        {
            string salt = HexSaltGenerator.NewSalt(64);

            Assert.IsNotNull(salt);
            Assert.IsFalse(salt.Contains('-'));

            // Salt is a Hex code for 64 bits we have 124 chars
            Assert.AreEqual(128, salt.Length);
        }
    }
}
