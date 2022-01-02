/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
            EmailListAttribute emailListAttribute = new();

            // null is valid
            Assert.IsTrue(emailListAttribute.IsValid(null));
            Assert.IsTrue(emailListAttribute.IsValid(new string[] { "testemail1@test.com", "testemail2@test.com" }));

            // must be list
            Assert.IsFalse(emailListAttribute.IsValid("testemail@test.com"));

            Assert.IsFalse(emailListAttribute.IsValid(new string[] { "testemail1", "testemail2@test.com" }));
        }
    }
}
