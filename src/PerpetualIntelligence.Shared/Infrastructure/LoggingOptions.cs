/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic logging configuration options.
    /// </summary>
    public class LoggingOptions
    {
        /// <summary>
        /// The string used to obscure error arguments. Defaults to <c>****</c>.
        /// </summary>
        /// <seealso cref="ObsureErrorArguments"/>
        public string ObscureErrorArgumentString { get; set; } = "****";

        /// <summary>
        /// Obscures the arguments in the error description to hide the sensitive data. Defaults to <c>true</c>.
        /// </summary>
        /// <remarks>Use <see cref="ObscureErrorArgumentString"/> to configure the obscure string.</remarks>
        /// <seealso cref="ObscureErrorArgumentString"/>
        public bool ObsureErrorArguments { get; set; } = true;
    }
}
