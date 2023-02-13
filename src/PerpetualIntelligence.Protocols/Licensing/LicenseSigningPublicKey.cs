/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The license signing public key.
    /// </summary>
    /// <remarks>
    /// When a license is signed using public/private key pairs, the signature certifies that only the party holding the private key is the one that signed it.
    /// </remarks>
    public sealed class LicenseSigningPublicKey
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="publicKey">The private key to sign a license.</param>
        [JsonConstructor]
        public LicenseSigningPublicKey(byte[] publicKey)
        {
            PublicKey = publicKey;
        }

        /// <summary>
        /// The public key.
        /// </summary>
        [JsonPropertyName("public_key")]
        public byte[] PublicKey { get; }
    }
}