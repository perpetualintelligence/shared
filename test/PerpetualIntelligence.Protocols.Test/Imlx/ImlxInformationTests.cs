/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Reflection;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class ImlxInformationTests
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
