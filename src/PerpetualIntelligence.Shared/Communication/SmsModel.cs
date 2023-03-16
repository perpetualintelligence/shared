/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Communication
{
    /// <summary>
    /// The email model.
    /// </summary>
    public class SmsModel
    {
        /// <summary>
        /// Email Bcc.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// From phone number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = null!;

        /// <summary>
        /// To phone number.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = null!;
    }
}