/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
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
