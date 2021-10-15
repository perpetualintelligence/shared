// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class ImlxWarningTests
    {
        [TestMethod]
        public void RequestIdTest()
        {
            Type type = typeof(ImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxWarning.RequestId));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "request_id", false);
        }

        [TestMethod]
        public void WarningTest()
        {
            Type type = typeof(ImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxWarning.Warning));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning", false);
        }

        [TestMethod]
        public void WarningDescriptionTest()
        {
            Type type = typeof(ImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxWarning.WarningDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_description", false);
        }

        [TestMethod]
        public void WarningUriTest()
        {
            Type type = typeof(ImlxWarning);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxWarning.WarningUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_uri", false);
        }
    }
}
