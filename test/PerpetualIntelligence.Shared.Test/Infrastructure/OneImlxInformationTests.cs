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
    public class OneImlxInformationTests
    {
        [TestMethod]
        public void InformationDescriptionTest()
        {
            Type type = typeof(OneImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxInformation.InformationDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_description", false);
        }

        [TestMethod]
        public void InformationTest()
        {
            Type type = typeof(OneImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxInformation.Information));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information", false);
        }

        [TestMethod]
        public void InformationUriTest()
        {
            Type type = typeof(OneImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxInformation.InformationUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_uri", false);
        }
    }
}
