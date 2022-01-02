/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class CustomDataTypesTest
    {
        [TestMethod]
        public void CustomDataTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(CustomDataTypes), 13);

            Assert.AreEqual("urn:oneimlx:cdt:bool", CustomDataTypes.Bool);
            Assert.AreEqual("urn:oneimlx:cdt:double", CustomDataTypes.Double);
            Assert.AreEqual("urn:oneimlx:cdt:enum", CustomDataTypes.Enumeration);
            Assert.AreEqual("urn:oneimlx:cdt:float", CustomDataTypes.Float);
            Assert.AreEqual("urn:oneimlx:cdt:int", CustomDataTypes.Int);
            Assert.AreEqual("urn:oneimlx:cdt:long", CustomDataTypes.Long);
            Assert.AreEqual("urn:oneimlx:cdt:mselect", CustomDataTypes.MultiSelect);
            Assert.AreEqual("urn:oneimlx:cdt:short", CustomDataTypes.Short);
            Assert.AreEqual("urn:oneimlx:cdt:sselect", CustomDataTypes.SingleSelect);
            Assert.AreEqual("urn:oneimlx:cdt:sdict", CustomDataTypes.StringDictionary);
            Assert.AreEqual("urn:oneimlx:cdt:slist", CustomDataTypes.StringList);
            Assert.AreEqual("urn:oneimlx:cdt:so", CustomDataTypes.SubObject);
            Assert.AreEqual("urn:oneimlx:cdt:solist", CustomDataTypes.SubObjectList);
        }
    }
}
