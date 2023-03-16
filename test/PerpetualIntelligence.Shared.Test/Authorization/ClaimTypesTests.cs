/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Authorization
{
    public class ClaimTypesTests
    {
        [Fact]
        public void Claims_Should_Be_Correct()
        {
            ClaimTypes.ConsumerObjectId.Should().Be("extension_CustomConsumerObjectId");
            ClaimTypes.ConsumerTenantId.Should().Be("extension_CustomConsumerTenantId");
            ClaimTypes.MarketplaceResolved.Should().Be("extension_CustomMarketplaceResolved");
            ClaimTypes.BrokerTenantId.Should().Be("extension_CustomBrokerTenantId");
            ClaimTypes.PublisherTenantId.Should().Be("extension_CustomPublisherTenantId");
            ClaimTypes.Marketplace.Should().Be("extension_CustomMarketplace");
            ClaimTypes.ForceResolve.Should().Be("extension_CustomForceResolve");
            ClaimTypes.ResolvedSubscriptionId.Should().Be("internal_CustomResolvedSubscriptionId");
            ClaimTypes.ResolvedSubscriptionStatus.Should().Be("internal_CustomResolvedSubscriptionStatus");
        }
    }
}
