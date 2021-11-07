/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Defines commonly used REGEX patterns.
    /// </summary>
    [ToUnitTest]
    [ToDocumentation]
    [Todo("Automate the documentation by adding DisplayAttribute and Group name and that use that to display limits in documentation. Or generate an json that can be used to generate documentation.")]
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