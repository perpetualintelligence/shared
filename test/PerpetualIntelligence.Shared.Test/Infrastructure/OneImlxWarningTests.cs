/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;
using System;
using System.Reflection;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class OneImlxWarningTests
    {
        [TestMethod]
        public void RequestIdTest()
        {
            Type type = typeof(OneImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxWarning.RequestId));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "request_id", false);
        }

        [TestMethod]
        public void WarningDescriptionTest()
        {
            Type type = typeof(OneImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxWarning.WarningDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_description", false);
        }

        [TestMethod]
        public void WarningTest()
        {
            Type type = typeof(OneImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxWarning.Warning));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning", false);
        }

        [TestMethod]
        public void WarningUriTest()
        {
            Type type = typeof(OneImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxWarning.WarningUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_uri", false);
        }
    }
}
