/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class ApiVersioningConstantsTests
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ApiVersioningConstants), 5);

            Assert.AreEqual("v1oneimlxidentity", ApiVersioningConstants.V1IdentityGroup);
            Assert.AreEqual("v1oneimlxinternal", ApiVersioningConstants.V1InternalGroup);
            Assert.AreEqual("v1oneimlxoidc", ApiVersioningConstants.V1OidcGroup);
            Assert.AreEqual("1.0", ApiVersioningConstants.V1);
            Assert.AreEqual("v1", ApiVersioningConstants.V1Url);
        }
    }
}
