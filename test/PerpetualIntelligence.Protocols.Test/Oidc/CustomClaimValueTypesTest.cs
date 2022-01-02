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
