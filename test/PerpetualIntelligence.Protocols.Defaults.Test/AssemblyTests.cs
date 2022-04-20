/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Defaults
{
    [TestClass]
    public class AssemblyTests
    {
        [TestMethod]
        public void TypesNamespaceTest()
        {
            TestHelper.AssertNamespace(typeof(Comparers.OrderIndependentComparer).Assembly, "PerpetualIntelligence.Protocols.Defaults");
        }

        [TestMethod]
        public void TypesTypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Comparers.OrderIndependentComparer).Assembly);
        }
    }
}
