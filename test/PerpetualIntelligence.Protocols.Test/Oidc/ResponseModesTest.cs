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
    public class ResponseModesTest
    {
        [TestMethod]
        public void ResponseModesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ResponseModes), 3);

            Assert.AreEqual("form_post", ResponseModes.FormPost);
            Assert.AreEqual("fragment", ResponseModes.Fragment);
            Assert.AreEqual("query", ResponseModes.Query);
        }
    }
}
