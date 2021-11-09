/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
            Assert.IsNotNull(IdGenerator.NewLongId());
        }

        [TestMethod]
        public void NewShortIdTest()
        {
            Assert.IsNotNull(IdGenerator.NewShortId());
        }
    }
}
