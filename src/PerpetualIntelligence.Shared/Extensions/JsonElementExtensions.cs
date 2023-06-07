/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// <see cref="JsonElement"/> extension methods
    /// </summary>
    [WriteUnitTest]
    public static class JsonElementExtensions
    {
        /// <summary>
        /// Converts the <see cref="JsonElement"/> to a list of <see cref="Claim"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/> containing claims.</param>
        /// <param name="issuer">Optional issuer name to add to claims.</param>
        /// <param name="excludeKeys">Claims to exclude.</param>
        /// <returns>An array of <see cref="Claim"/>.</returns>
        /// <remarks>All the claim values are converted to string.</remarks>
        public static Claim[] ToClaims(this JsonElement json, string? issuer = null, params string[] excludeKeys)
        {
            var claims = new List<Claim>();
            var excludeList = excludeKeys.ToList();

            foreach (var x in json.EnumerateObject())
            {
                if (excludeList.Contains(x.Name))
                {
                    continue;
                }

                if (x.Value.ValueKind == JsonValueKind.Array)
                {
                    foreach (var item in x.Value.EnumerateArray())
                    {
                        claims.Add(new Claim(x.Name, ConvertToString(item), ClaimValueTypes.String, issuer));
                    }
                }
                else
                {
                    claims.Add(new Claim(x.Name, ConvertToString(x.Value), ClaimValueTypes.String, issuer));
                }
            }

            return claims.ToArray();
        }

        /// <summary>
        /// Attempts to get a boolean from a <see cref="JsonElement"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/></param>
        /// <param name="name">The name of the property to find.</param>
        public static bool? TryGetBoolean(this JsonElement json, string name)
        {
            var value = json.TryGetString(name);

            if (bool.TryParse(value, out bool result))
            {
                return result;
            }

            return null;
        }

        /// <summary>
        /// Attempts to get an int from a <see cref="JsonElement"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/>.</param>
        /// <param name="name">The name of the property to find.</param>
        public static int? TryGetInt(this JsonElement json, string name)
        {
            var value = json.TryGetString(name);

            if (value != null)
            {
                if (int.TryParse(value, out int intValue))
                {
                    return intValue;
                }
            }

            return null;
        }

        /// <summary>
        /// Attempts to get a string from a <see cref="JsonElement"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/>.</param>
        /// <param name="name">The name of the property to find.</param>
        public static string? TryGetString(this JsonElement json, string name)
        {
            JsonElement value = json.TryGetValue(name);
            return value.ValueKind == JsonValueKind.Undefined ? null : value.ToString();
        }

        /// <summary>
        /// Attempts to get an array of string from a <see cref="JsonElement"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/>.</param>
        /// <param name="name">The name of the property to find.</param>
        public static IEnumerable<string> TryGetStringArray(this JsonElement json, string name)
        {
            var values = new List<string>();

            var array = json.TryGetValue(name);
            if (array.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in array.EnumerateArray())
                {
                    values.Add(item.ToString());
                }
            }

            return values;
        }

        /// <summary>
        /// Attempts to get a value from a <see cref="JsonElement"/>.
        /// </summary>
        /// <param name="json">The <see cref="JsonElement"/>.</param>
        /// <param name="name">The name of the property to find.</param>
        public static JsonElement TryGetValue(this JsonElement json, string name)
        {
            if (json.ValueKind == JsonValueKind.Undefined)
            {
                return default;
            }

            return json.TryGetProperty(name, out JsonElement value) ? value : default;
        }

        private static string ConvertToString(JsonElement item)
        {
            return item.ValueKind == JsonValueKind.String ? item.ToString() : item.GetRawText();
        }
    }
}
