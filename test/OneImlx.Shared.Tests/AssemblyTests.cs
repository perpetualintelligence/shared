/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.FluentAssertions;
using Xunit;

namespace OneImlx.Shared
{
    public class AssemblyTests
    {
        [Fact]
        public void TypesNamespaceTest()
        {
            typeof(Infrastructure.Error).Assembly.Should().HaveTypesInRootNamespace("OneImlx.Shared");
        }

        [Fact]
        public void TypesLocationTest()
        {
            typeof(Infrastructure.Error).Assembly.Should().HaveTypesInValidLocations();
        }
    }
}