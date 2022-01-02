/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Defines commonly used REGEX patterns.
    /// </summary>
    [WriteUnitTest]
    public static class RegexPatterns
    {
        /// <summary>
        /// Pattern containing only letters a-z or A-Z.
        /// </summary>
        public const string Letters = "^[a-zA-Z]+$";

        /// <summary>
        /// Pattern containing only letters a-z or A-Z, numbers 0-9, dash, and underscore.
        /// </summary>
        public const string LettersNumbersDashUnderscore = "^([A-Za-z0-9-]_?)+$";

        /// <summary>
        /// Pattern containing only letters a-z or A-Z, numbers 0-9, dash, underscore and comma.
        /// </summary>
        public const string LettersNumbersDashUnderscoreComma = "^([A-Za-z0-9-]_,?)+$";

        /// <summary>
        /// Pattern containing only letters a-z or A-Z, numbers 0-9, dash, and underscore.
        /// </summary>
        public const string LettersNumbersDashUnderscoreSpace = "^([A-Za-z0-9][\\-\\h_]?)+$";
    }
}
