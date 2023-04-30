/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared
{
    public class AssemblyTests
    {
        [Fact]
        public void TypesNamespaceTest()
        {
            TestHelper.AssertNamespace(typeof(Infrastructure.Modes).Assembly, "PerpetualIntelligence.Shared");
        }

        [Fact]
        public void TypesTypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Infrastructure.Modes).Assembly);
        }
    }
}