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
    public class ImlxInformationTests
    {
        [TestMethod]
        public void InformationTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.Information));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information", false);
        }

        [TestMethod]
        public void InformationDescriptionTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.InformationDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_description", false);
        }

        [TestMethod]
        public void InformationUriTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.InformationUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_uri", false);
        }
    }
}
