/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
