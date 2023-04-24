/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared
{
    public class ConstantsTest
    {
        [Fact]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Constants), 7);

            Constants.Cli.Should().Be("pi-cli");
            Constants.CliUrn.Should().Be("urn:oneimlx:cli");

            Constants.Lic.Should().Be("pi-lic");
            Constants.LicUrn.Should().Be("urn:oneimlx:lic");

            Constants.OneImlx.Should().Be("oneimlx");
            Constants.OneImlxUrn.Should().Be("urn:oneimlx");

            Constants.Issuer.Should().Be("https://api.perpetualintelligence.com");
        }
    }
}