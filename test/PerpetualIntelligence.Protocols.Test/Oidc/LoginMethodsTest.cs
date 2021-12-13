// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class LoginMethodsTest
    {
        [TestMethod]
        public void LoginMethodsConstantsTest()
        {
            // NOTE: Update the assert checks below if you change the constants.
            TestHelper.AssertConstantCount(typeof(LoginMethods), 4);

            Assert.AreEqual("urn:oneimlx:oidc:login:pwd", LoginMethods.Password);
            Assert.AreEqual("urn:oneimlx:oidc:login:pin", LoginMethods.Pin);
            Assert.AreEqual("urn:oneimlx:oidc:login:otp", LoginMethods.Otp);
            Assert.AreEqual("urn:oneimlx:oidc:login:unknown", LoginMethods.Unknown);
        }
    }
}
