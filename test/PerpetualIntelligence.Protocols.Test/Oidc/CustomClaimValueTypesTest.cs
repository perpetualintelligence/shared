// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class CustomClaimValueTypesTest
    {
        [TestMethod]
        public void ClaimValueTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(CustomClaimValueTypes), 1);

            Assert.AreEqual("urn:oneimlx:oidc:claimvalue:json", CustomClaimValueTypes.Json);
        }
    }
}
