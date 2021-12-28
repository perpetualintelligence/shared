/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Identifies an entity uniquely with an <c>id</c> and an optional <c>partition_id</c>, if the entity is partitioned.
    /// </summary>
    public class Identity
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="partitionId">The partition id.</param>
        /// <param name="id">The id.</param>
        public Identity(string partitionId, string id)
        {
            PartitionId = partitionId;
            Id = id;
        }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="id">The id.</param>
        [JsonConstructor]
        public Identity(string id)
        {
            Id = id;
        }

        /// <summary>
        /// The identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Determines if the identity has a <c>partition_id</c>.
        /// </summary>
        [JsonIgnore]
        public bool IsPartitioned
        {
            get
            {
                return (PartitionId != null);
            }
        }

        /// <summary>
        /// The partition identifier.
        /// </summary>
        [JsonPropertyName("partition_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartitionId { get; set; }

        /// <inheritdoc/>
        public static bool operator !=(Identity? left, Identity? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public static bool operator ==(Identity? left, Identity? right)
        {
            return EqualityComparer<Identity?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as Identity);
        }

        /// <inheritdoc/>
        public bool Equals(Identity? other)
        {
            return other != null &&
                   Id == other.Id &&
                   PartitionId == other.PartitionId;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
#if NETSTANDARD2_1_OR_GREATER
            return System.HashCode.Combine(Id, PartitionId);
#else
            int hashCode = Id.GetHashCode();
            if (PartitionId != null)
            {
                hashCode ^= PartitionId.GetHashCode();
            }
            return hashCode;
#endif
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            if (PartitionId == null)
            {
                return Id;
            }
            else
            {
                return $"partition_id={PartitionId} id={Id}";
            }
        }
    }
}
