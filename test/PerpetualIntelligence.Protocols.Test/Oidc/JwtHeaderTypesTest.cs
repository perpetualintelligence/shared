// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class JwtHeaderTypesTest
    {
        [TestMethod]
        public void JwtDefaultTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(JwtHeaderTypes), 2);

            Assert.AreEqual("urn:oneimlx:oidc:jwttyp:at", JwtHeaderTypes.AccessToken);
            Assert.AreEqual("urn:oneimlx:oidc:jwttyp:ar", JwtHeaderTypes.AuthorizationRequest);
        }
    }
}
