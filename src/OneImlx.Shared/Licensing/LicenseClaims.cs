/*
    Copyright (c) 2023 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using OneImlx.Shared.Infrastructure;
using OneImlx.Shared.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The generic license claims.
    /// </summary>
    public sealed class LicenseClaims
    {
        /// <summary>
        /// Initialize a new instance. This constructor is part of the internal infrastructure. Please do not use it
        /// directly in the application code. To create a new instance from claims please use <see cref="Create(IDictionary{string, object})"/>.
        /// </summary>
        public LicenseClaims()
        {
        }

        /// <summary>
        /// The <c>acr</c> claim values.
        /// </summary>
        [JsonPropertyName("acr_values")]
        public string AcrValues { get; set; } = null!;

        /// <summary>
        /// The <c>aud</c> claim.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; } = null!;

        /// <summary>
        /// The <c>apps</c> claim.
        /// </summary>
        [JsonPropertyName("applications")]
        public string Applications { get; set; } = null!;

        /// <summary>
        /// The <c>azp</c> claim.
        /// </summary>
        [JsonPropertyName("authorized_party")]
        public string AuthorizedParty { get; set; } = null!;

        /// <summary>
        /// The custom claims.
        /// </summary>
        [JsonPropertyName("custom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(DictionaryStringObjectPrimitiveJsonConverter))]
        public Dictionary<string, object>? Custom { get; set; }

        /// <summary>
        /// The <c>exp</c> claim.
        /// </summary>
        [JsonPropertyName("expiry_at")]
        public DateTimeOffset ExpiryAt { get; set; }

        /// <summary>
        /// The <c>iat</c> claim.
        /// </summary>
        [JsonPropertyName("issued_at")]
        public DateTimeOffset IssuedAt { get; set; }

        /// <summary>
        /// The <c>iss</c> claim.
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; } = null!;

        /// <summary>
        /// The <c>jti</c> claim.
        /// </summary>
        [JsonPropertyName("jti")]
        public string Jti { get; set; } = null!;

        /// <summary>
        /// The <c>name</c> claim.
        /// </summary>
        [JsonPropertyName("tenant_name")]
        public string TenantName { get; set; } = null!;

        /// <summary>
        /// The <c>nbf</c> claim.
        /// </summary>
        [JsonPropertyName("not_before")]
        public DateTimeOffset NotBefore { get; set; }

        /// <summary>
        /// The <c>sub</c> claim.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; } = null!;

        /// <summary>
        /// The <c>country</c> claim.
        /// </summary>
        [JsonPropertyName("tenant_country")]
        public string TenantCountry { get; set; } = null!;

        /// <summary>
        /// The <c>tid</c> claim.
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; } = null!;

        /// <summary>
        /// The <c>oid</c> claim.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The <c>mode</c> claim.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; } = null!;

        /// <summary>
        /// The <c>deployment</c> claim.
        /// </summary>
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; } = null!;

        /// <summary>
        /// Creates a new instance of <see cref="LicenseClaims"/> based on the specified claims dictionary.
        /// </summary>
        /// <param name="claims">The source claims.</param>
        public static LicenseClaims Create(IDictionary<string, object> claims)
        {
            try
            {
                LicenseClaims fromClaims = new();

                foreach (var kvp in claims)
                {
                    switch (kvp.Key)
                    {
                        case "name":
                            {
                                fromClaims.TenantName = kvp.Value.ToString();
                                continue;
                            }
                        case "aud":
                            {
                                fromClaims.Audience = kvp.Value.ToString();
                                continue;
                            }
                        case "iss":
                            {
                                fromClaims.Issuer = kvp.Value.ToString();
                                continue;
                            }
                        case "jti":
                            {
                                fromClaims.Jti = kvp.Value.ToString();
                                continue;
                            }
                        case "sub":
                            {
                                fromClaims.Subject = kvp.Value.ToString();
                                continue;
                            }
                        case "tid":
                            {
                                fromClaims.TenantId = kvp.Value.ToString();
                                continue;
                            }
                        case "oid":
                            {
                                fromClaims.Id = kvp.Value.ToString();
                                continue;
                            }
                        case "country":
                            {
                                fromClaims.TenantCountry = kvp.Value.ToString();
                                continue;
                            }
                        case "azp":
                            {
                                fromClaims.AuthorizedParty = kvp.Value.ToString();
                                continue;
                            }
                        case "apps":
                            {
                                fromClaims.Applications = kvp.Value.ToString();
                                continue;
                            }
                        case "acr":
                            {
                                fromClaims.AcrValues = kvp.Value.ToString();
                                continue;
                            }
                        case "exp":
                            {
                                fromClaims.ExpiryAt = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(claims["exp"]));
                                continue;
                            }
                        case "iat":
                            {
                                fromClaims.IssuedAt = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(claims["iat"]));
                                continue;
                            }
                        case "nbf":
                            {
                                fromClaims.NotBefore = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(claims["nbf"]));
                                continue;
                            }
                        case "mode":
                            {
                                fromClaims.Mode = Convert.ToString(claims["mode"]);
                                continue;
                            }
                        case "deployment":
                            {
                                fromClaims.Deployment = Convert.ToString(claims["deployment"]);
                                continue;
                            }
                        default:
                            {
                                fromClaims.Custom ??= [];
                                fromClaims.Custom.Add(kvp.Key, kvp.Value);

                                continue;
                            }
                    }
                }

                return fromClaims;
            }
            catch (Exception ex)
            {
                throw new ErrorException("missing_claim", "The claim is missing in the request. info={0}", ex.Message);
            }
        }
    }
}