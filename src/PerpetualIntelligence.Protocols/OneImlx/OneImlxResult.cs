/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The generic <c>oneimlx</c> result.
    /// </summary>
    public class OneImlxResult
    {
        /// <summary>
        /// The errors.
        /// </summary>
        public OneImlxError[]? Errors { get; set; }

        /// <summary>
        /// The informations.
        /// </summary>
        public OneImlxInformation[]? Informations { get; set; }

        /// <summary>
        /// The warnings.
        /// </summary>
        public OneImlxWarning[]? Warnings { get; set; }
    }
}
