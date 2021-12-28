/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
