/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>acr_values</c> supported by the <c>oneimlx</c> OAuth or OpenID Connect authorization server.
    /// </summary>
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
        /// The allowed chargeables.
        /// </summary>
        public const string AllowedChargeables = "urn:pi:protocols:oidc:acr:achrgs";

        /// <summary>
        /// The IDP or an Identity Provider.
        /// </summary>
        public const string Idp = "urn:pi:protocols:oidc:acr:idp";

        /// <summary>
        /// The subscribed chargeables.
        /// </summary>
        public const string SubscribedChargeables = "urn:pi:protocols:oidc:acr:schrgs";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Tenant = "urn:pi:protocols:oidc:acr:tenant";

        /// <summary>
        /// The account for multi-tenancy.
        /// </summary>
        public const string Account = "urn:pi:protocols:oidc:acr:account";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Organization = "urn:pi:protocols:oidc:acr:org";

        /// <summary>
        /// The tenant for multi-tenancy.
        /// </summary>
        public const string Department = "urn:pi:protocols:oidc:acr:dept";
    }
}
