/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// An <see cref="Identity"/> with mode support.
    /// </summary>
    /// <seealso cref="Modes"/>
    public sealed class ModeIdentity : Identity
    {
        /// <summary>
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="partitionId"></param>
        /// <param name="id"></param>
        public ModeIdentity(string mode, string partitionId, string id) : base(partitionId, id)
        {
            Mode = mode;
            PartitionId = partitionId;
            Id = id;
        }

        /// <summary>
        /// The mode.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; }
    }
}
