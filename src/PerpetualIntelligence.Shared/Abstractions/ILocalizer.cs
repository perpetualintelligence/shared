/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/
/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.Extensions.Localization;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of the localizer.
    /// </summary>
    public interface ILocalizer : IStringLocalizer
    {
        /// <summary>
        /// Finds a locale specific string for the specified translation unit id.
        /// </summary>
        /// <param name="tuId">The translation unit identifier.</param>
        /// <returns>An instance of <see cref="LocalizedString"/>.</returns>
        LocalizedString Find(string tuId);

        /// <summary>
        /// Finds a formated locale specific string for the specified translation unit id.
        /// </summary>
        /// <param name="tuId">The translation unit identifier.</param>
        /// <param name="arguments">The format arguments.</param>
        /// <returns>An instance of <see cref="LocalizedString"/>.</returns>
        LocalizedString Find(string tuId, params object[] arguments);

        /// <summary>
        /// Translates the specified string input and returns a locale specific string.
        /// </summary>
        /// <param name="input">String to translate.</param>
        /// <returns>An instance of <see cref="LocalizedString"/>.</returns>
        Task<LocalizedString> TranslateAsync(string input);
    }
}
