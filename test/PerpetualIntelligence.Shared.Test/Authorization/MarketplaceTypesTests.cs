/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Authorization
{
    public class MarketplaceTypesTests
    {
        [Fact]
        public void MarketplaceTypes_Should_Be_Valid()
        {
            MarketplaceTypes.Aws.Should().Be("urn:oneimlx:mkt:aws");
            MarketplaceTypes.Microsoft.Should().Be("urn:oneimlx:mkt:ms");
            MarketplaceTypes.Stripe.Should().Be("urn:oneimlx:mkt:stripe");
        }
    }
}
