/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        public const string Critical = "urn:pi:protocol:imlx:severity:crit";

        /// <summary>
        /// High impact to business with no available workaround.
        /// </summary>
        public const string High = "urn:pi:protocol:imlx:severity:high";

        /// <summary>
        /// Low severities cosmetic changes.
        /// </summary>
        public const string Low = "urn:pi:protocol:imlx:severity:low";

        /// <summary>
        /// Medium impact to business but with available workaround.
        /// </summary>
        public const string Medium = "urn:pi:protocol:imlx:severity:med";

        /// <summary>
        /// Business impact is unknown and severity to be decided.
        /// </summary>
        public const string Tbd = "urn:pi:protocol:imlx:severity:tbd";
    }
}
