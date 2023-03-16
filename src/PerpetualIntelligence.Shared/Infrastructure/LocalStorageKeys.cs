/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The <c>oneimlx</c> local storage keys.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    public sealed class LocalStorageKeys
    {
        /// <summary>
        /// Determines the diagnostic state from the local storage.
        /// </summary>
        public const string IsDiagnostic = "urn:oneimlx:lsk:isdiag";

        /// <summary>
        /// Determines the layer luminance for the <c>fast</c> color theme.
        /// </summary>
        public const string LayerLuminance = "urn:oneimlx:lsk:layer";

        /// <summary>
        /// Determines whether to show the localizer profix.
        /// </summary>
        public const string IsLocalizationPrefixed = "urn:oneimlx:lsk:isl10prefixed";
    }
}
