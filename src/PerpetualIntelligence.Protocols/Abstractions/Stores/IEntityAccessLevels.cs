/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
{
    /// <summary>
    /// Provides the access levels for an entity.
    /// </summary>
    public interface IEntityAccessLevels : IEntity
    {
        /// <summary>
        /// The access level 1.
        /// </summary>
        /// <value>Level 1 string identifier.</value>
        string? Level1Id { get; }

        /// <summary>
        /// The access level 2.
        /// </summary>
        /// <value>Level 2 string identifier.</value>
        string? Level2Id { get; }

        /// <summary>
        /// The access level 3.
        /// </summary>
        /// <value>Level 3 string identifier.</value>
        string? Level3Id { get; }

        /// <summary>
        /// The access level 4.
        /// </summary>
        /// <value>Level 4 string identifier.</value>
        string? Level4Id { get; }

        /// <summary>
        /// The access level 5.
        /// </summary>
        /// <value>Level 5 string identifier.</value>
        string? Level5Id { get; }
    }
}
