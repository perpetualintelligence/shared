/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Protocols.Authorization
{
    public class AppTypesTests
    {
        [Fact]
        public void AppTypes_Should_Be_Valid()
        {
            AppTypes.CliApplication.Should().Be("urn:oneimlx:apps:cliapp");
            AppTypes.ConsumerPortal.Should().Be("urn:oneimlx:apps:consumerportal");
            AppTypes.PublisherPortal.Should().Be("urn:oneimlx:apps:publisherportal");
            AppTypes.Undefined.Should().Be("urn:oneimlx:apps:undefined");
            AppTypes.Client.Should().Be("urn:oneimlx:apps:client");
        }
    }
}
