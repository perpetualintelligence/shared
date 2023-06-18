/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using Xunit;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    public class CustomDataTypesTest
    {
        [Fact]
        public void CustomDataTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(CustomDataTypes), 7);

            CustomDataTypes.Enumeration.Should().Be("urn:oneimlx:cdt:enum");
            CustomDataTypes.MultiSelect.Should().Be("urn:oneimlx:cdt:mselect");
            CustomDataTypes.SingleSelect.Should().Be("urn:oneimlx:cdt:sselect");
            CustomDataTypes.StringDictionary.Should().Be("urn:oneimlx:cdt:sdict");
            CustomDataTypes.StringList.Should().Be("urn:oneimlx:cdt:slist");
            CustomDataTypes.SubObject.Should().Be("urn:oneimlx:cdt:so");
            CustomDataTypes.SubObjectList.Should().Be("urn:oneimlx:cdt:solist");
        }
    }
}