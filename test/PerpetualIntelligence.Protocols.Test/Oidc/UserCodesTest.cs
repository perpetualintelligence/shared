/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
