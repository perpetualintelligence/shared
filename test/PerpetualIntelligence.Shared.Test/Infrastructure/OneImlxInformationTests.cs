/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
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
