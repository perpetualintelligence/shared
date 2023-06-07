/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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
