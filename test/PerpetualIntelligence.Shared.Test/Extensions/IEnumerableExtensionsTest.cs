// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Extensions;

namespace PerpetualIntelligence.Shared.Extensions
{
    [TestClass]
   public class IEnumerableExtensionsTest
    {
        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            Assert.IsTrue(IEnumerableExtensions.IsNullOrEmpty(""));

            Assert.IsFalse(IEnumerableExtensions.IsNullOrEmpty("Test"));
        }
    }
}
