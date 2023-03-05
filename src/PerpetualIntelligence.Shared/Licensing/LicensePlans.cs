/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Licensing
{
    /// <summary>
    /// The standard license pricing plans.
    /// </summary>
    public sealed class LicensePlans
    {
        /// <summary>
        /// Determines if the plan is valid.
        /// </summary>
        /// <returns><c>true</c> if the plan is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string plan)
        {
            switch (plan)
            {
                case Community:
                case Micro:
                case SMB:
                case Custom:
                case Enterprise:
                case ISV:
                case ISVU:
                case None:
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
        /// The community license pricing plan.
        /// </summary>
        public const string Community = "urn:oneimlx:lic:plan:community";

        /// <summary>
        /// The custom license pricing plan.
        /// </summary>
        public const string Custom = "urn:oneimlx:lic:plan:custom";

        /// <summary>
        /// The enterprise license pricing plan.
        /// </summary>
        public const string Enterprise = "urn:oneimlx:lic:plan:enterprise";

        /// <summary>
        /// The ISV license pricing plan.
        /// </summary>
        public const string ISV = "urn:oneimlx:lic:plan:isv";

        /// <summary>
        /// The ISV unlimited license pricing plan.
        /// </summary>
        public const string ISVU = "urn:oneimlx:lic:plan:isvu";

        /// <summary>
        /// The solo or micro license pricing plan.
        /// </summary>
        public const string Micro = "urn:oneimlx:lic:plan:micro";

        /// <summary>
        /// The neutral or no license pricing plan.
        /// </summary>
        public const string None = "urn:oneimlx:lic:plan:none";

        /// <summary>
        /// The SMB license pricing plan.
        /// </summary>
        public const string SMB = "urn:oneimlx:lic:plan:smb";        
    }
}
