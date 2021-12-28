/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ClientAssertionsTest
    {
        [TestMethod]
        public void ClientAssertionTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ClientAssertions), 2);

            Assert.AreEqual("urn:ietf:params:oauth:client-assertion-type:jwt-bearer", ClientAssertions.JwtBearer);
            Assert.AreEqual("urn:ietf:params:oauth:client-assertion-type:saml2-bearer", ClientAssertions.SamlBearer);
        }
    }
}
