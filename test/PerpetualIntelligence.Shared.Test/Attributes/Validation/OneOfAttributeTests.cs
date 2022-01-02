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
