﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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
