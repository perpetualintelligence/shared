/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class AllowedAttributeTests
    {
        [TestMethod]
        public void IsValidArrayShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            AllowedAttribute allowedAttribute = new AllowedAttribute(allowed);

            Assert.IsTrue(allowedAttribute.IsValid(new string[] { "test1", "test2" }));

            Assert.IsFalse(allowedAttribute.IsValid(new string[] { "test1", "test5" }));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }

        [TestMethod]
        public void IsValidShouldReturnValidResult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            AllowedAttribute allowedAttribute = new AllowedAttribute(allowed);

            Assert.IsTrue(allowedAttribute.IsValid("test1"));
            Assert.IsTrue(allowedAttribute.IsValid("test2"));
            Assert.IsFalse(allowedAttribute.IsValid("test5"));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }
    }
}
