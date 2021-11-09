// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class ImlxErrorTest
    {
        [TestMethod]
        public void ErrorTest()
        {
            Type type = typeof(OneImlxError);
            PropertyInfo? prop = type.GetProperty(nameof(OneImlxError.Error));

            Assert.IsNotNull(prop);
            TestHelper.AssertAttributeCount(prop, 1, false);
            TestHelper.AssertJsonPropertyName(prop, "error", false);
        }
    }
}
