/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Communication
{
    /// <summary>
    /// The reCAPTCHA check model.
    /// </summary>
    public class RecaptchaModel
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="token"></param>
        [JsonConstructor]
        public RecaptchaModel(string token)
        {
            Token = token;
        }

        /// <summary>
        /// The reCAPTCHA token to check.
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
