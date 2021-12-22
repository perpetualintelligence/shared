/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
