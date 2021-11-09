/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared
{
    [TestClass]
    public class AssemblyTests
    {
        [TestMethod]
        public void TypesNamespaceTest()
        {
            TestHelper.AssertNamespace(typeof(Infrastructure.Modes).Assembly, "PerpetualIntelligence.Shared");
        }

        [TestMethod]
        public void TypesTypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Infrastructure.Modes).Assembly);
        }
    }
}
