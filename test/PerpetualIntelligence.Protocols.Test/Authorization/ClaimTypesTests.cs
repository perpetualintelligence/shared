/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Protocols.Authorization
{
    public class ClaimTypesTests
    {
        [Fact]
        public void Claims_Should_Be_Correct()
        {
            ClaimTypes.ConsumerObjectId.Should().Be("extension_CustomConsumerObjectId");
            ClaimTypes.ConsumerTenantId.Should().Be("extension_CustomConsumerTenantId");
            ClaimTypes.MarketplaceResolved.Should().Be("extension_CustomMarketplaceResolved");
            ClaimTypes.ProviderTenantId.Should().Be("extension_CustomProviderTenantId");
            ClaimTypes.PublisherTenantId.Should().Be("extension_CustomPublisherTenantId");
            ClaimTypes.SocialLoginObjectId.Should().Be("extension_CustomSocialLoginObjectId");
            ClaimTypes.SocialLoginTenantId.Should().Be("extension_CustomSocialLoginTenantId");
        }
    }
}
