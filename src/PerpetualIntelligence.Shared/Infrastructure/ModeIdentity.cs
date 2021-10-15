/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
