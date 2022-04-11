/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// Defines the standard SaaS pricing plans.
    /// </summary>
    public class SaaSPlans
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
        /// The community SaaS pricing plan.
        /// </summary>
        public const string Community = "urn:oneimlx:lic:saasplan:community";

        /// <summary>
        /// The custom SaaS pricing plan.
        /// </summary>
        public const string Custom = "urn:oneimlx:lic:saasplan:custom";

        /// <summary>
        /// The enterprise SaaS pricing plan.
        /// </summary>
        public const string Enterprise = "urn:oneimlx:lic:saasplan:enterprise";

        /// <summary>
        /// The ISV SaaS pricing plan.
        /// </summary>
        public const string ISV = "urn:oneimlx:lic:saasplan:isv";

        /// <summary>
        /// The ISV unlimited SaaS pricing plan.
        /// </summary>
        public const string ISVU = "urn:oneimlx:lic:saasplan:isvu";

        /// <summary>
        /// The solo or micro SaaS pricing plan.
        /// </summary>
        public const string Micro = "urn:oneimlx:lic:saasplan:micro";

        /// <summary>
        /// The SMB SaaS pricing plan.
        /// </summary>
        public const string SMB = "urn:oneimlx:lic:saasplan:smb";
    }
}
