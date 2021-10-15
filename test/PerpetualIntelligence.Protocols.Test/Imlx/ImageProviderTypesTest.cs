// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
   public class ImageProviderTypesTest
    {
        [TestMethod]
        public void InternalCommandLineArgumentsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ImageProviderTypes), 2);

            Assert.AreEqual("urn:pi:protocols:imlx:img:upload", ImageProviderTypes.Upload);
            Assert.AreEqual("urn:pi:protocols:imlx:img:url", ImageProviderTypes.Url);
        }
    }
}
