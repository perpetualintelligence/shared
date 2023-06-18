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
    public class PrimitiveDataTypesTests
    {
        [Fact]
        public void Primitives_Are_Correct()
        {
            TestHelper.AssertConstantCount(typeof(PrimitiveDataTypes), 8);

            PrimitiveDataTypes.Bool.Should().Be("urn:oneimlx:pdt:bool");
            PrimitiveDataTypes.Byte.Should().Be("urn:oneimlx:pdt:byte");
            PrimitiveDataTypes.Double.Should().Be("urn:oneimlx:pdt:double");
            PrimitiveDataTypes.Float.Should().Be("urn:oneimlx:pdt:float");
            PrimitiveDataTypes.Int.Should().Be("urn:oneimlx:pdt:int");
            PrimitiveDataTypes.Long.Should().Be("urn:oneimlx:pdt:long");
            PrimitiveDataTypes.Short.Should().Be("urn:oneimlx:pdt:short");
            PrimitiveDataTypes.String.Should().Be("urn:oneimlx:pdt:string");
        }
    }
}