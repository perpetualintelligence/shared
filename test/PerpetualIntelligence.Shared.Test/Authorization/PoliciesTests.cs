/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Authorization
{
    public class PoliciesTests
    {
        [Fact]
        public void Policies_Should_Be_Correct()
        {
            Policies.Authenticated.Should().Be("urn:oneimlx:policies:authenticated");
            Policies.Consumer.Should().Be("urn:oneimlx:policies:consumer");
            Policies.Publisher.Should().Be("urn:oneimlx:policies:publisher");
        }
    }
}
