// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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

            Assert.AreEqual("urn:pi:protocols:oidc:login:pwd", LoginMethods.Password);
            Assert.AreEqual("urn:pi:protocols:oidc:login:pin", LoginMethods.Pin);
            Assert.AreEqual("urn:pi:protocols:oidc:login:otp", LoginMethods.Otp);
            Assert.AreEqual("urn:pi:protocols:oidc:login:unknown", LoginMethods.Unknown);
        }
    }
}
