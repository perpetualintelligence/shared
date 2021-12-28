/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// Define the severity based on business impact.
    /// </summary>
    public static class Severity
    {
        /// <summary>
        /// Return all the severities that represents a potential impact.
        /// </summary>
        public static string[] Impact
        {
            get
            {
                return new string[]
                {
                    Critical,
                    High,
                    Medium,
                    Low
                };
            }
        }

        /// <summary>
        /// Critical impact to business with no available workaround.
        /// </summary>
        public const string Critical = "urn:oneimlx:severity:crit";

        /// <summary>
        /// High impact to business with no available workaround.
        /// </summary>
        public const string High = "urn:oneimlx:severity:high";

        /// <summary>
        /// Low severities or cosmetic changes.
        /// </summary>
        public const string Low = "urn:oneimlx:severity:low";

        /// <summary>
        /// Medium impact to business but with available workaround.
        /// </summary>
        public const string Medium = "urn:oneimlx:severity:med";

        /// <summary>
        /// Business impact is unknown and severity to be decided.
        /// </summary>
        public const string Tbd = "urn:oneimlx:severity:tbd";
    }
}
