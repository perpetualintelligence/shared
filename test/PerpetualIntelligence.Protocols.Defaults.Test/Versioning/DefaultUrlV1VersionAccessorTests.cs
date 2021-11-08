/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

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
