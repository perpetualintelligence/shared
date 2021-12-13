/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class EmailListAttributeTests
    {
        [TestMethod]
        public void IsValidShouldReturnValidResult()
        {
            EmailListAttribute emailListAttribute = new EmailListAttribute();

            // null is valid
            Assert.IsTrue(emailListAttribute.IsValid(null));
            Assert.IsTrue(emailListAttribute.IsValid(new string[] { "testemail1@test.com", "testemail2@test.com" }));

            // must be list
            Assert.IsFalse(emailListAttribute.IsValid("testemail@test.com"));

            Assert.IsFalse(emailListAttribute.IsValid(new string[] { "testemail1", "testemail2@test.com" }));
        }
    }
}
