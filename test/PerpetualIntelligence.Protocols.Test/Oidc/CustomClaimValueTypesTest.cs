// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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

            Assert.AreEqual("urn:pi:protocols:oidc:claimvalue:json", CustomClaimValueTypes.Json);
        }
    }
}
