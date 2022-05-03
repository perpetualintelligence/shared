/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;
using FluentAssertions;

namespace PerpetualIntelligence.Shared.Json
{
    /// <summary>
    /// </summary>
    public class DictionaryStringObjectPrimitiveJsonConverterTests
    {
        [Fact]
        public void PrimitiveType_ShouldDeserilizeCorrectly()
        {
            DateTime utcNow = DateTime.UtcNow;
            Dictionary<string, object?> testValues = new()
            {
                { "k1", -3625 },
                { "k2", 25636 },
                { "k3", false },
                { "k4", true },
                { "k5", -365.3699 },
                { "k6", 3655.366 },
                { "k7", "test string" },
                { "k8", utcNow },
            };

            TestData testData = new TestData()
            {
                Data = testValues
            };

            string json = JsonSerializer.Serialize(testData);

            TestData? fromJson = JsonSerializer.Deserialize<TestData>(json);
            fromJson.Should().NotBeNull();
            fromJson!.Data.Should().HaveCount(8);
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k1", -3625));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k2", 25636));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k3", false));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k4", true));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k5", -365.3699));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k6", 3655.366));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k7", "test string"));
            fromJson.Data.Should().Contain(new KeyValuePair<string, object?>("k8", utcNow));
        }

        [Fact]
        public void UnsupportedType_ShouldThrowError()
        {
            DateTime utcNow = DateTime.UtcNow;
            Dictionary<string, object?> testValues = new()
            {
                { "k1", new object() },
            };

            TestData testData = new TestData()
            {
                Data = testValues
            };

            string json = JsonSerializer.Serialize(testData);
            Action act = () => JsonSerializer.Deserialize<TestData>(json);
            act.Should().Throw<JsonException>().WithMessage("'StartObject' is not supported. The key must be a string, and the value must be a primitive type, string, or date-time.");
        }

        public class TestData
        {
            [JsonPropertyName("data")]
            [JsonConverter(typeof(DictionaryStringObjectPrimitiveJsonConverter))]
            public Dictionary<string, object?>? Data { get; set; }
        }
    }
}
