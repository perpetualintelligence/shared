//  Copyright © 2019-2026 Perpetual Intelligence L.L.C. All rights reserved.
//  For license, terms, and data policies, go to:
//  https://terms.perpetualintelligence.com/articles/intro.html

using System;
using System.Text.Json.Serialization;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace OneImlx.Test.FluentAssertions
{
    public class TypeFluentAssertionsTests
    {
        [Fact]
        public void HaveConstantCountShouldPassWhenCountMatches()
        {
            typeof(SampleWithConstants).Should().HaveConstantCount(2);
        }

        [Fact]
        public void HaveConstantCountShouldFailWhenCountDoesNotMatch()
        {
            FluentActions.Invoking(() => typeof(SampleWithConstants).Should().HaveConstantCount(99))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HavePropertyCountShouldPassWhenCountMatches()
        {
            typeof(SampleWithProperties).Should().HavePropertyCount(2);
        }

        [Fact]
        public void HavePropertyCountShouldFailWhenCountDoesNotMatch()
        {
            FluentActions.Invoking(() => typeof(SampleWithProperties).Should().HavePropertyCount(99))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HaveJsonPropertyShouldPassWhenAttributeMatches()
        {
            typeof(SampleWithJsonProps).Should().HaveJsonProperty(nameof(SampleWithJsonProps.FirstName), "first_name");
        }

        [Fact]
        public void HaveJsonPropertyShouldFailWhenPropertyMissing()
        {
            FluentActions.Invoking(() => typeof(SampleWithJsonProps).Should().HaveJsonProperty("NonExistent", "non_existent"))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HaveJsonPropertyShouldFailWhenJsonNameDoesNotMatch()
        {
            FluentActions.Invoking(() => typeof(SampleWithJsonProps).Should().HaveJsonProperty(nameof(SampleWithJsonProps.FirstName), "wrong_name"))
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HaveSnakeCaseJsonNamesShouldPassWhenAllPropertiesDecoratedCorrectly()
        {
            typeof(SampleWithValidSnakeCase).Should().HaveSnakeCaseJsonNames();
        }

        [Fact]
        public void HaveSnakeCaseJsonNamesShouldFailWhenPropertyHasNoAttribute()
        {
            FluentActions.Invoking(() => typeof(SampleWithMissingAttribute).Should().HaveSnakeCaseJsonNames())
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HaveSnakeCaseJsonNamesShouldFailWhenJsonNameIsNotSnakeCase()
        {
            FluentActions.Invoking(() => typeof(SampleWithWrongJsonName).Should().HaveSnakeCaseJsonNames())
                .Should().Throw<AssertionFailedException>();
        }

        [Fact]
        public void HaveSnakeCaseJsonNamesShouldPassWhenPropertyIsJsonIgnored()
        {
            typeof(SampleWithJsonIgnore).Should().HaveSnakeCaseJsonNames();
        }

        private class SampleWithConstants
        {
            public const string ConstOne = "one";
            public const string ConstTwo = "two";
        }

        private class SampleWithProperties
        {
            public string? Name { get; set; }
            public int Age { get; set; }
        }

        private class SampleWithJsonProps
        {
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }
        }

        private class SampleWithValidSnakeCase
        {
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }

            [JsonPropertyName("last_name")]
            public string? LastName { get; set; }
        }

        private class SampleWithMissingAttribute
        {
            public string? FirstName { get; set; }
        }

        private class SampleWithWrongJsonName
        {
            [JsonPropertyName("firstName")]
            public string? FirstName { get; set; }
        }

        private class SampleWithJsonIgnore
        {
            [JsonIgnore]
            public string? InternalProp { get; set; }
        }
    }
}