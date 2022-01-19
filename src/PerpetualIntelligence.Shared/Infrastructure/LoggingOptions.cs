/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> logging configuration options.
    /// </summary>
    public class LoggingOptions
    {
        /// <summary>
        /// The string used to obscure error arguments. Defaults to <c>****</c>.
        /// </summary>
        /// <seealso cref="RevealErrorArguments"/>
        public string ObscureErrorArgumentString { get; set; } = "****";

        /// <summary>
        /// Reveals the arguments in the error description. By default, the arguments are obscured to hide the sensitive
        /// information. Use <see cref="ObscureErrorArgumentString"/> to configure the obscure string.
        /// </summary>
        /// <seealso cref="ObscureErrorArgumentString"/>
        public bool? RevealErrorArguments { get; set; }
    }
}
