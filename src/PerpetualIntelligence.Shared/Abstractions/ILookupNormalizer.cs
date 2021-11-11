/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction for normalizing email, name, key and identifier.
    /// </summary>
    [MustDo("Microsoft.AspNetCore.Identity already has ILookupNormalizer")]
    public interface ILookupNormalizer
    {
        /// <summary>
        /// Normalizes the specified email.
        /// </summary>
        /// <returns>The normalized email.</returns>
        string NormalizeEmail(string email);

        /// <summary>
        /// Normalizes the specified id.
        /// </summary>
        /// <returns>The normalized id.</returns>
        string NormalizeId(string id);

        /// <summary>
        /// Normalizes the specified key.
        /// </summary>
        /// <returns>The normalized key.</returns>
        string NormalizeKey(string key);

        /// <summary>
        /// Normalizes the specified name.
        /// </summary>
        /// <returns>The normalized name.</returns>
        string NormalizeName(string name);
    }
}
