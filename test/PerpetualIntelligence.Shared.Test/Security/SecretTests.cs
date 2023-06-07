/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using PerpetualIntelligence.Test.Services;
using System;
using System.Reflection;
using Xunit;

namespace PerpetualIntelligence.Shared.Security.Secrets
{
    public class SecretTests
    {
        [Fact]
        public void DescriptionTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Description));

            prop.Should().NotBeNull();

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "description", false);
        }

        [Fact]
        public void ExpirationTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Expiration));

            prop.Should().NotBeNull();

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "expiration", false);
        }

        [Fact]
        public void NameTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Name));

            prop.Should().NotBeNull();

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "name", false);
        }

        [Fact]
        public void TypeTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Type));

            prop.Should().NotBeNull();

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "type", false);
        }

        [Fact]
        public void ValueTest()
        {
            Type type = typeof(Secret);
            PropertyInfo? prop = type.GetProperty(nameof(Secret.Value));

            prop.Should().NotBeNull();

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "value", false);
        }
    }
}