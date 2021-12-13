/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class RegexPatternsTest
    {
        [TestMethod]
        public void RegexPatternsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(RegexPatterns), 4);

            Assert.AreEqual("^[a-zA-Z]+$", RegexPatterns.Letters);

            Assert.AreEqual("^([A-Za-z0-9-]_?)+$", RegexPatterns.LettersNumbersDashUnderscore);

            Assert.AreEqual("^([A-Za-z0-9-]_,?)+$", RegexPatterns.LettersNumbersDashUnderscoreComma);

            Assert.AreEqual("^([A-Za-z0-9][\\-\\h_]?)+$", RegexPatterns.LettersNumbersDashUnderscoreSpace);
        }
    }
}
