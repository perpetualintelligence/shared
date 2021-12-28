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
    public class ResponseTypesTest
    {
        [TestMethod]
        public void ResponseTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ResponseTypes), 7);

            Assert.AreEqual("code", ResponseTypes.Code);
            Assert.AreEqual("code id_token", ResponseTypes.CodeIdToken);
            Assert.AreEqual("code id_token token", ResponseTypes.CodeIdTokenToken);
            Assert.AreEqual("code token", ResponseTypes.CodeToken);
            Assert.AreEqual("id_token", ResponseTypes.IdToken);
            Assert.AreEqual("id_token token", ResponseTypes.IdTokenToken);
            Assert.AreEqual("token", ResponseTypes.Token);
        }
    }
}
