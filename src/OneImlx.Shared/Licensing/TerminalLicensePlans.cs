/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The standard license pricing plans.
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
                case Micro:
                case SMB:
                case Enterprise:
                case OnPremise:
                case Unlimited:
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
        /// The demo license pricing plan.
        /// </summary>
        public const string Demo = "urn:oneimlx:terminal:plan:demo";

        /// <summary>
        /// The custom license pricing plan.
        /// </summary>
        public const string Custom = "urn:oneimlx:terminal:plan:custom";

        /// <summary>
        /// The enterprise license pricing plan.
        /// </summary>
        public const string Enterprise = "urn:oneimlx:terminal:plan:enterprise";

        /// <summary>
        /// The on-premise license pricing plan.
        /// </summary>
        public const string OnPremise = "urn:oneimlx:terminal:plan:onprem";

        /// <summary>
        /// The unlimited license pricing plan.
        /// </summary>
        public const string Unlimited = "urn:oneimlx:terminal:plan:unlimited";

        /// <summary>
        /// The solo or micro license pricing plan.
        /// </summary>
        public const string Micro = "urn:oneimlx:terminal:plan:micro";

        /// <summary>
        /// The SMB license pricing plan.
        /// </summary>
        public const string SMB = "urn:oneimlx:terminal:plan:smb";
    }
}