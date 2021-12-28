/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction for normalizing email, name, key and identifier.
    /// </summary>
    public interface ILookupNormalizer
    {
        /// <summary>
        /// Normalizes the specified email.
        /// </summary>
        /// <param name="email">The email to normalize.</param>
        /// <returns>The normalized email.</returns>
        string NormalizeEmail(string email);

        /// <summary>
        /// Normalizes the specified id.
        /// </summary>
        /// <param name="id">The id to normalize.</param>
        /// <returns>The normalized id.</returns>
        string NormalizeId(string id);

        /// <summary>
        /// Normalizes the specified key.
        /// </summary>
        /// <param name="key">The key to normalize.</param>
        /// <returns>The normalized key.</returns>
        string NormalizeKey(string key);

        /// <summary>
        /// Normalizes the specified name.
        /// </summary>
        /// <param name="name">The name to normalize.</param>
        /// <returns>The normalized name.</returns>
        string NormalizeName(string name);
    }
}
