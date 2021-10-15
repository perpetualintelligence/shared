/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols
{
    [TestClass]
    public class AssemblyTests
    {
        [TestMethod]
        public void TypesNamespaceTest()
        {
            TestHelper.AssertNamespace(typeof(Imlx.OrgConstants).Assembly, "PerpetualIntelligence.Protocols");
        }

        [TestMethod]
        public void TypesTypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Imlx.OrgConstants).Assembly);
        }
    }
}
