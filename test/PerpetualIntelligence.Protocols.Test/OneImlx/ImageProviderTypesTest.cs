/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class ImageProviderTypesTest
    {
        [TestMethod]
        public void InternalCommandLineArgumentsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ImageProviderTypes), 2);

            Assert.AreEqual("urn:oneimlx:img:upload", ImageProviderTypes.Upload);
            Assert.AreEqual("urn:oneimlx:img:url", ImageProviderTypes.Url);
        }
    }
}
