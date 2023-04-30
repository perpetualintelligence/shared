/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Shared.Security.Secrets
{
    public class SecretComparerTest
    {
        [Fact]
        public void ConstantTimeComparerIsEqualTest()
        {
            SecretComparer.IsEqual("", "").Should().BeTrue();
            SecretComparer.IsEqual("TestString", "").Should().BeFalse();
            SecretComparer.IsEqual("Test", "Test1").Should().BeFalse();
            SecretComparer.IsEqual("Test", "TesT").Should().BeFalse();
            SecretComparer.IsEqual("TestString", "TestString").Should().BeTrue();
        }
    }
}