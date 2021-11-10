/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
