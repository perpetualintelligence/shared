/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Defaults.Versioning
{
    [TestClass]
    public class DefaultUrlV1VersionAccessorTests
    {
        [TestMethod]
        public void GetVersionShouldReturnV1()
        {
            DefaultUrlV1VersionAccessor accessor = new DefaultUrlV1VersionAccessor();
            Assert.AreEqual("v1", accessor.GetVersion());
        }
    }
}
