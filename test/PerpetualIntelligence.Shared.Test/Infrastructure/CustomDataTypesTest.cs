/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Data.Shared.Rendering
{
    [TestClass]
    public class CustomDataTypesTest
    {
        [TestMethod]
        public void CustomDataTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(CustomDataTypes), 10);

            Assert.AreEqual("Bool", CustomDataTypes.Bool);
            Assert.AreEqual("Double", CustomDataTypes.Double);
            Assert.AreEqual("Enumeration", CustomDataTypes.Enumeration);
            Assert.AreEqual("Int", CustomDataTypes.Int);
            Assert.AreEqual("MultiSelect", CustomDataTypes.MultiSelect);
            Assert.AreEqual("SingleSelect", CustomDataTypes.SingleSelect);
            Assert.AreEqual("StringDictionary", CustomDataTypes.StringDictionary);
            Assert.AreEqual("StringList", CustomDataTypes.StringList);
            Assert.AreEqual("SubObject", CustomDataTypes.SubObject);
            Assert.AreEqual("SubObjectList", CustomDataTypes.SubObjectList);
        }
    }
}
