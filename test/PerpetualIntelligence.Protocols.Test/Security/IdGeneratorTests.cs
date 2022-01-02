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
    public class IdGeneratorTests
    {
        [TestMethod]
        public void NewGuidTest()
        {
            Assert.IsNotNull(IdGenerator.NewGuid());
        }

        [TestMethod]
        public void NewLongIdTest()
        {
            string id = IdGenerator.NewLongId();
            Assert.IsNotNull(id);
            Assert.IsFalse(id.Contains('-'));
        }

        [TestMethod]
        public void NewShortIdTest()
        {
            string id = IdGenerator.NewShortId();
            Assert.IsNotNull(id);
            Assert.IsFalse(id.Contains("[/+= -]"));
        }
    }
}
