/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
            StringLengthListAttribute  stringLengthListAttribute = new(8);

            // null is valid
            Assert.IsTrue(stringLengthListAttribute.IsValid(null));
            Assert.IsTrue(stringLengthListAttribute.IsValid(new string[] { "testval1", "testval2" }));

            // must be list
            Assert.IsFalse(stringLengthListAttribute.IsValid(new string[] { "testval1", "test_long_val2" }));
        }
    }
}
