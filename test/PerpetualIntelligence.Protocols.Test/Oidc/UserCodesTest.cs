/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class UserCodesTest
    {
        [TestMethod]
        public void UserCodeTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(UserCodes), 2);

            Assert.AreEqual("urn:oneimlx:oidc:ucode:anum", UserCodes.AlphaNumeric);
            Assert.AreEqual("urn:oneimlx:oidc:ucode:num", UserCodes.Numeric);
        }
    }
}
