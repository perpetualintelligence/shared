/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The generic online license provisioning model.
    /// </summary>
    public sealed class LicenseOnlineProvisioningModel : LicenseProvisioningModel
    {

        /// <summary>
        /// The space separated keys operations. Valid value is <c>actions</c>, <c>get</c>, <c>generate</c>,
        /// <c>reset_primary</c>, <c>reset_secondary</c> and <c>delete</c>.
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; } = null!;
    }
}