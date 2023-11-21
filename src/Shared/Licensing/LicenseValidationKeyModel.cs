/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Licensing
{
    /// <summary>
    /// The license validation public key.
    /// </summary>
    /// <remarks>
    /// When a license is signed using public/private key pairs, the signature certifies that only the party holding the private key is the one that signed it.
    /// </remarks>
    public sealed class LicenseValidationKeyModel
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="key">The public key to validate a license.</param>
        [JsonConstructor]
        public LicenseValidationKeyModel(byte[] key)
        {
            Key = key;
        }

        /// <summary>
        /// The validation key.
        /// </summary>
        [JsonPropertyName("key")]
        public byte[] Key { get; }
    }
}