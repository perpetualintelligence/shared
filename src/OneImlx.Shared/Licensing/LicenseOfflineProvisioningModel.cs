/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Text.Json.Serialization;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The generic offline license provisioning model.
    /// </summary>
    public sealed class LicenseOfflineProvisioningModel : LicenseProvisioningModel
    {
        /// <summary>
        /// The offline license signing key.
        /// </summary>
        [JsonPropertyName("signing_key")]
        public LicenseSigningKeyModel SigningKey { get; set; } = null!;
    }
}