/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class IOHelperTests
    {
        [TestMethod]
        public void GetParentTest()
        {
            Assert.AreEqual(@"C:\Users\pisuser2\AppData\Local\Programs", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera"));
        }

        [TestMethod]
        public void GetParentTestLevels()
        {
            Assert.AreEqual(@"C:\Users\pisuser2\AppData", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera", 3));

            Assert.AreEqual(@"C:\Users", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera", 5));
        }

        [TestMethod]
        public void NullOrEmptyParentShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent(null), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent("  "), "Invalid path. (Parameter 'path')");
        }

        [TestMethod]
        public void NullOrEmptyParentWithLevelsShouldThrowException()
        {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent(null, 2), "Invalid path. (Parameter 'path')");
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            TestHelper.AssertThrowsWithMessage<ArgumentException>(() => IOHelper.GetParent("  ", 2), "Invalid path. (Parameter 'path')");
        }
    }
}
