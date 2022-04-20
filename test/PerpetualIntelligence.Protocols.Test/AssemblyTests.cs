/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
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
            TestHelper.AssertNamespace(typeof(Constants).Assembly, "PerpetualIntelligence.Protocols");
        }

        [TestMethod]
        public void TypesTypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Constants).Assembly);
        }
    }
}
