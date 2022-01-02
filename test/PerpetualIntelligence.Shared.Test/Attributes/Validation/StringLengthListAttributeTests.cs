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
    public class StringLengthListAttributeTests
    {
        [TestMethod]
        public void IsValidShouldReturnValidResult()
        {
            StringLengthListAttribute stringLengthListAttribute = new(8);

            // null is valid
            Assert.IsTrue(stringLengthListAttribute.IsValid(null));
            Assert.IsTrue(stringLengthListAttribute.IsValid(new string[] { "testval1", "testval2" }));

            // must be list
            Assert.IsFalse(stringLengthListAttribute.IsValid(new string[] { "testval1", "test_long_val2" }));
        }
    }
}
