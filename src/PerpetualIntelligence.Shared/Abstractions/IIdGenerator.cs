/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of an id generator.
    /// </summary>
    /// <remarks>
    /// The <see cref="IIdGenerator"/> can generate regular text id, numeric id, partitioned id and mode id.
    /// </remarks>
    /// <seealso cref="Identity"/>
    /// <seealso cref="ModeIdentity"/>
    /// <seealso cref="Modes"/>
    public interface IIdGenerator
    {
        /// <summary>
        /// Decodes the specified mode identifier.
        /// </summary>
        /// <param name="modeId">The mode identifier to decode.</param>
        /// <returns>An identity instance that represents the decoded mode identifier.</returns>
        ModeIdentity DecodeModeId(string modeId);

        /// <summary>
        /// Decodes the specified partitioned identifier.
        /// </summary>
        /// <param name="partitionedId">The partitioned identifier to decode.</param>
        /// <param name="splitId"><c>true</c> to split the partitionedId identifier, otherwise <c>false</c>.</param>
        /// <returns>An identity instance that represents a decoded partitioned identifier.</returns>
        Identity DecodePartitionedId(string partitionedId, bool splitId);

        /// <summary>
        /// Generates a new long identifier. Typically this a long version of a <see cref="System.Guid"/>.
        /// </summary>
        /// <returns>A new long identifier.</returns>
        string NewLongId();

        /// <summary>
        /// Generates a new mode identifier. A mode identifier is a compound identifier of the specified mode, partition
        /// identifier and a new unique identifier.
        /// </summary>
        /// <param name="mode">The mode. See <see cref="Modes"/>.</param>
        /// <param name="partitionId">The partition identifier.</param>
        /// <returns>A new mode identifier.</returns>
        string NewModeId(string mode, string partitionId);

        /// <summary>
        /// Generates a new numeric identifier.
        /// </summary>
        /// <returns>A new numeric identifier.</returns>
        int NewNumericId();

        /// <summary>
        /// Generates a new partitioned identifier. A partitioned identifier is a compound identifier of the specified
        /// partition identifier and a new unique identifier.
        /// </summary>
        /// <param name="partitionId">The partition identifier.</param>
        /// <returns>A new partitioned identifier.</returns>
        string NewPartitionedId(string partitionId);

        /// <summary>
        /// Generates a new short identifier. Typically this a short version of a <see cref="System.Guid"/> while
        /// maintaining the uniqueness.
        /// </summary>
        /// <returns>A new short identifier.</returns>
        string NewShortId();
    }
}
