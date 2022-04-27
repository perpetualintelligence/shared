/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The logging configuration options.
    /// </summary>
    public class LoggingOptions
    {
        /// <summary>
        /// The string used to obscure error description arguments. The default value is <c>****</c>.
        /// </summary>
        /// <seealso cref="ObsureErrorArguments"/>
        public string ObscureErrorArgumentString { get; set; } = "****";

        /// <summary>
        /// Obscures the arguments in the error description to hide the sensitive data. The default value is <c>true</c>.
        /// </summary>
        /// <remarks>Use <see cref="ObscureErrorArgumentString"/> to configure the obscure string.</remarks>
        /// <seealso cref="ObscureErrorArgumentString"/>
        public bool ObsureErrorArguments { get; set; } = true;
    }
}
