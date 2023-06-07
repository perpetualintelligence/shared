/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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

            Constants.Terminal.Should().Be("pi-cli");
            Constants.TerminalUrn.Should().Be("urn:oneimlx:picli");

            Constants.Licensing.Should().Be("pi-lic");
            Constants.LicensingUrn.Should().Be("urn:oneimlx:pilic");

            Constants.OneImlx.Should().Be("oneimlx");
            Constants.OneImlxUrn.Should().Be("urn:oneimlx");

            Constants.Issuer.Should().Be("https://api.perpetualintelligence.com");
        }
    }
}