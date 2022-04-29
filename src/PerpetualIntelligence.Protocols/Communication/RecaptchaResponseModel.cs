/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Communication
{
    /// <summary>
    /// The reCAPTCHA response model.
    /// </summary>
    public class RecaptchaResponseModel
    {
        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("challenge_ts")]
        public DateTime? ChallengeTs { get; set; }

        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("error-codes")]
        public string[]? ErrorCodes { get; set; }

        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("hostname")]
        public string? HostName { get; set; }

        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// The reCAPTCHA action.
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
    }
}
