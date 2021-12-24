/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ApplicationTypesTest
    {
        [TestMethod]
        public void ApplicationTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Applications), 2);

            Assert.AreEqual("native", Applications.Native);
            Assert.AreEqual("web", Applications.Web);
        }
    }
}
