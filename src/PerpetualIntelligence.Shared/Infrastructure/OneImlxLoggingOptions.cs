/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic <c>oneimlx</c> logging configuration options.
    /// </summary>
    public class OneImlxLoggingOptions
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
