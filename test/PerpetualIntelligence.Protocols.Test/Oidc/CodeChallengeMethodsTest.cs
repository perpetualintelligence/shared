// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class CodeChallengeMethodsTest
    {
        [TestMethod]
        public void CodeChallengeMethodsConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(CodeChallengeMethods), 2);

            Assert.AreEqual("plain", CodeChallengeMethods.Plain);
            Assert.AreEqual("S256", CodeChallengeMethods.Sha256);
        }
    }
}
