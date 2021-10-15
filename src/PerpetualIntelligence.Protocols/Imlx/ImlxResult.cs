/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The generic <c>imlx</c> result that may have multiple errors, warnings or informations.
    /// </summary>
    public class ImlxResult
    {
        /// <summary>
        /// The errors.
        /// </summary>
        public ImlxError[]? Errors { get; set; }

        /// <summary>
        /// The informations.
        /// </summary>
        public ImlxInformation[]? Informations { get; set; }

        /// <summary>
        /// The warnings.
        /// </summary>
        public ImlxWarning[]? Warnings { get; set; }
    }
}
