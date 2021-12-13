/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Reflection;

namespace PerpetualIntelligence.Protocols.Security.Secrets
{
    [TestClass]
    public class SecretTests
    {
        [TestMethod]
        public void DescriptionTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Description));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "description", false);
        }

        [TestMethod]
        public void ExpirationTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Expiration));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "expiration", false);
        }

        [TestMethod]
        public void NameTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Name));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "name", false);
        }

        [TestMethod]
        public void TypeTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Type));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "type", false);
        }

        [TestMethod]
        public void ValueTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Value));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "value", false);
        }
    }
}
