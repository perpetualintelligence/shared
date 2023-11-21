/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Communication
{
    /// <summary>
    /// The email model.
    /// </summary>
    public class EmailModel
    {
        /// <summary>
        /// Email Bcc.
        /// </summary>
        [JsonPropertyName("bcc")]
        public string[]? Bcc { get; set; }

        /// <summary>
        /// Email message.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Email Cc.
        /// </summary>
        [JsonPropertyName("cc")]
        public string[]? Cc { get; set; }

        /// <summary>
        /// Email from.
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Email to.
        /// </summary>
        [JsonPropertyName("to")]
        public string[] To { get; set; } = null!;
    }
}
