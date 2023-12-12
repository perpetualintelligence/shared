/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using OneImlx.Test.Services;
using Xunit;

namespace OneImlx.Shared
{
    public class AssemblyTests
    {
        [Fact]
        public void TypesNamespaceTest()
        {
            TestHelper.AssertNamespace(typeof(Infrastructure.Error).Assembly, "OneImlx.Shared");
        }

        [Fact]
        public void TypesLocationTest()
        {
            TestHelper.AssertAssemblyTypesLocation(typeof(Infrastructure.Error).Assembly);
        }
    }
}