/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>acr_values</c> supported by the <c>oneimlx</c> authorization server.
    /// </summary>
    public static class AcrValues
    {
        /// <summary>
        /// All the supported <c>acr_values</c>.
        /// </summary>
        /// <returns>An array of all the supported <c>acr</c> values.</returns>
        public static string[] All
        {
            get
            {
                return new string[]
                {
                    Idp,
                    Tenant,
                    TenantLevel1,
                    TenantLevel2,
                    TenantLevel3,
                    TenantLevel4,
                    TenantLevel5,
                    AllowedChargeables,
                    SubscribedChargeables
                };
            }
        }

        /// <summary>
        /// The allowed chargeable.
        /// </summary>
        public const string AllowedChargeables = "urn:oneimlx:oidc:acr:achrgs";

        /// <summary>
        /// The IDP or an Identity Provider.
        /// </summary>
        public const string Idp = "urn:oneimlx:oidc:acr:idp";

        /// <summary>
        /// The subscribed chargeable.
        /// </summary>
        public const string SubscribedChargeables = "urn:oneimlx:oidc:acr:schrgs";

        /// <summary>
        /// The tenant identifier to enable multi-tenancy.
        /// </summary>
        public const string Tenant = "urn:oneimlx:oidc:acr:tenant";

        /// <summary>
        /// The tenant level1 identifier for scoping and access control within a tenant.
        /// </summary>
        public const string TenantLevel1 = "urn:oneimlx:oidc:acr:tl1";

        /// <summary>
        /// The tenant level2 identifier for scoping and access control within tenant level1.
        /// </summary>
        public const string TenantLevel2 = "urn:oneimlx:oidc:acr:tl2";

        /// <summary>
        /// The tenant level3 identifier for scoping and access control within tenant level2.
        /// </summary>
        public const string TenantLevel3 = "urn:oneimlx:oidc:acr:tl3";

        /// <summary>
        /// The tenant level4 identifier for scoping and access control within tenant level3.
        /// </summary>
        public const string TenantLevel4 = "urn:oneimlx:oidc:acr:tl4";

        /// <summary>
        /// The tenant level5 identifier for scoping and access control within tenant level4.
        /// </summary>
        public const string TenantLevel5 = "urn:oneimlx:oidc:acr:tl5";
    }
}
