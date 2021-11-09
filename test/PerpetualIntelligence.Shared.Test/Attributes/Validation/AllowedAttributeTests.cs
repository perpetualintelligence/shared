using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class AllowedAttributeTests
    {
        [TestMethod]
        public void IsValidShouldReturnValidTesult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            AllowedAttribute allowedAttribute = new AllowedAttribute(allowed);

            Assert.IsTrue(allowedAttribute.IsValid("test1"));
            Assert.IsTrue(allowedAttribute.IsValid("test2"));
            Assert.IsFalse(allowedAttribute.IsValid("test5"));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }


        [TestMethod]
        public void IsValidArrayShouldReturnValidTesult()
        {
            string[] allowed = new string[] { "test1", "test2", "test3", "test4" };

            AllowedAttribute allowedAttribute = new AllowedAttribute(allowed);

            Assert.IsTrue(allowedAttribute.IsValid(new string[] { "test1", "test2" }));

            Assert.IsFalse(allowedAttribute.IsValid(new string[] { "test1", "test5" }));

            // null is valid, this is useful for data validation when nothing is entered
            Assert.IsTrue(allowedAttribute.IsValid(null));
        }

    }
}
