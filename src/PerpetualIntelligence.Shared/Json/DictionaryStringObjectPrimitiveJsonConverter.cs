/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Json
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> for dictionary of <see cref="string"/> and <see cref="object"/>.
    /// The value must be primitive, <c>null</c>, <c>string</c> or <see cref="DateTime"/>.
    /// </summary>
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-converters-how-to?pivots=dotnet-6-0#sample-factory-pattern-converter"/>
    public class DictionaryStringObjectPrimitiveJsonConverter : JsonConverter<Dictionary<string, object?>>
    {
        /// <inheritdoc/>
        public override Dictionary<string, object?> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException($"The Json token {reader.TokenType}, is not supported");
            }

            var dictionary = new Dictionary<string, object?>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return dictionary;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("The Json token is not a PropertyName");
                }

                string? propertyName = reader.GetString();
                if (propertyName == null)
                {
                    throw new JsonException("Failed to get property name");
                }

                // Get the value
                if (!reader.Read())
                {
                    throw new JsonException("Failed to read the value.");
                }

                dictionary.Add(propertyName, ExtractValue(ref reader, options));
            }

            return dictionary;
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, Dictionary<string, object?> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }

        /// <summary>
        /// Deserialize inferred types to object properties.
        /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-converters-how-to?pivots=dotnet-6-0#deserialize-inferred-types-to-object-properties
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>

        private object? ExtractValue(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    {
                        // String can be a date
                        if (reader.TryGetDateTime(out var date))
                        {
                            return date;
                        }

                        return reader.GetString();
                    }

                case JsonTokenType.False:
                    {
                        return false;
                    }

                case JsonTokenType.True:
                    {
                        return true;
                    }

                case JsonTokenType.Null:
                    {
                        return null;
                    }

                case JsonTokenType.Number:
                    {
                        if (reader.TryGetInt64(out var longVal))
                        {
                            return longVal;
                        }

                        if (reader.TryGetDouble(out var doubVal))
                        {
                            return doubVal;
                        }

                        return reader.GetDecimal();
                    }

                default:
                    throw new JsonException($"'{reader.TokenType}' is not supported. The key must be a string, and the value must be a primitive type, string, or date-time.");
            }
        }
    }
}
