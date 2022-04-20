/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class OneOfAttributeTests
    {
        [TestMethod]
        public void IsValidArrayShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            OneOfAttribute allowedAttribute = new(allowed);

            Assert.IsTrue(allowedAttribute.IsValid(new string[] { "test1", "test2" }));

            Assert.IsFalse(allowedAttribute.IsValid(new string[] { "test1", "test5" }));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }

        [TestMethod]
        public void IsValidShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            OneOfAttribute allowedAttribute = new(allowed);

            Assert.IsTrue(allowedAttribute.IsValid("test1"));
            Assert.IsTrue(allowedAttribute.IsValid("test2"));
            Assert.IsFalse(allowedAttribute.IsValid("test5"));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }
    }
}
