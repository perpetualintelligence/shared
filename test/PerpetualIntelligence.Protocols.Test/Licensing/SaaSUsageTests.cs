/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Licensing
{
    [TestClass]
    public class SaaSUsageTests
    {
        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSPlans()
        {
            Assert.IsFalse(SaaSUsage.IsValid("invalid"));
        }

        [TestMethod]
        public void IsValidShouldReturnTrueForValidUsage()
        {
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.Commercial));
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.Educational));
            Assert.IsTrue(SaaSUsage.IsValid(SaaSUsage.Test));
        }

        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSUsage), 3);

            Assert.AreEqual("urn:oneimlx:lic:saasusage:commerce", SaaSUsage.Commercial);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:edu", SaaSUsage.Educational);
            Assert.AreEqual("urn:oneimlx:lic:saasusage:test", SaaSUsage.Test);
        }
    }
}
