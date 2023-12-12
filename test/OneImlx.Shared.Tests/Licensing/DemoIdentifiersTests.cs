/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class DemoIdentifiersTests
    {
        [Fact]
        public void Identifiers_Are_Correct()
        {
            DemoIdentifiers.TerminalDemoAuthorizedApplicationId.Should().Be("da7fa6f5-3127-49f3-9682-2f7412d3f48c");
            DemoIdentifiers.TerminalDemoConsumerTenantName.Should().Be("terminal | demo-customer");
            DemoIdentifiers.TerminalDemoConsumerTenantId.Should().Be("abaf803b-3f24-4087-b18f-192ed279b01e");
            DemoIdentifiers.TerminalDemoSubject.Should().Be("f296bf8f-e951-4c9b-a8ba-ee912a574cfc");
        }
    }
}