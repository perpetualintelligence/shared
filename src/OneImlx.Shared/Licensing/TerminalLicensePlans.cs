/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The terminal framework license plans.
    /// </summary>
    public sealed class TerminalLicensePlans
    {
        /// <summary>
        /// Determines if the plan is valid for <c>terminal</c>.
        /// </summary>
        /// <returns><c>true</c> if the plan is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValidPlan(string plan)
        {
            switch (plan)
            {
                case Demo:
                case Solo:
                case Micro:
                case Smb:
                case Enterprise:
                case Corporate:
                case Custom:
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        /// <summary>
        /// The corporate license pricing plan.
        /// </summary>
        public const string Corporate = "urn:oneimlx:terminal:plan:corporate";

        /// <summary>
        /// The custom license pricing plan.
        /// </summary>
        public const string Custom = "urn:oneimlx:terminal:plan:custom";

        /// <summary>
        /// The demo license pricing plan.
        /// </summary>
        public const string Demo = "urn:oneimlx:terminal:plan:demo";

        /// <summary>
        /// The enterprise license pricing plan.
        /// </summary>
        public const string Enterprise = "urn:oneimlx:terminal:plan:enterprise";

        /// <summary>
        /// The micro license pricing plan.
        /// </summary>
        public const string Micro = "urn:oneimlx:terminal:plan:micro";

        /// <summary>
        /// The SMB license pricing plan.
        /// </summary>
        public const string Smb = "urn:oneimlx:terminal:plan:smb";

        /// <summary>
        /// The solo license pricing plan.
        /// </summary>
        public const string Solo = "urn:oneimlx:terminal:plan:solo";
    }
}
