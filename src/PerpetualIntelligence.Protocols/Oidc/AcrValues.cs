/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>acr_values</c> supported by the <c>oneimlx</c> authorization server.
    /// </summary>
    [MustDo("For multi-tenancy we have concept of tiers and org, depts. These needs to be merged as 1 concept.", BlockRelease = true)]
    public static class AcrValues
    {
        /// <summary>
        /// All the supported <c>acr_values</c>.
        /// </summary>
        /// <returns></returns>
        public static string[] All
        {
            get
            {
                return new string[]
                {
                    Idp,
                    Tenant,
                    Account,
                    Organization,
                    Department,
                    AllowedChargeables,
                    SubscribedChargeables
                };
            }
        }

        /// <summary>
        /// The account for multi-tenancy.
        /// </summary>
        public const string Account = "urn:oneimlx:oidc:acr:account";

        /// <summary>
        /// The allowed chargeables.
        /// </summary>
        public const string AllowedChargeables = "urn:oneimlx:oidc:acr:achrgs";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Department = "urn:oneimlx:oidc:acr:dept";

        /// <summary>
        /// The IDP or an Identity Provider.
        /// </summary>
        public const string Idp = "urn:oneimlx:oidc:acr:idp";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Organization = "urn:oneimlx:oidc:acr:org";

        /// <summary>
        /// The subscribed chargeables.
        /// </summary>
        public const string SubscribedChargeables = "urn:oneimlx:oidc:acr:schrgs";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Tenant = "urn:oneimlx:oidc:acr:tenant";
    }
}
