/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The scopes supported by the <c>OAuth2.0</c>, <c>OpenID Connect</c> and <c>oneimlx</c> protocols.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-basic-1_0.html#Scopes"/>
    [Todo("Finalize the oneimlx scopes.")]
    public static class Scopes
    {
        /// <summary>
        /// This scope value requests access to the <c>address</c> claim.
        /// </summary>
        public const string Address = "address";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's <c>api</c> claim.
        /// </summary>
        public const string Api = "urn:oneimlx:scope:api";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's <c>allowed_apps</c> and <c>subscribed_apps</c>.
        /// </summary>
        [Todo("Updatate this to correctly reflect the allowed_apps and subscribed_apps.")]
        public const string Application = "urn:oneimlx:scope:app";

        /// <summary>
        /// This scope value requests access to the <c>email</c> and <c>email_verified</c> claims.
        /// </summary>
        public const string Email = "email";

        /// <summary>
        /// This scope value requests that an OAuth 2.0 Refresh Token be issued that can be used to obtain an Access
        /// Token that grants access to the End-User's UserInfo Endpoint even when the End-User is not present (not
        /// logged in).
        /// </summary>
        public const string OfflineAccess = "offline_access";

        /// <summary>
        /// Informs the Authorization Server that the Client is making an OpenID Connect request. If the <c>openid</c>
        /// scope value is not present, the behavior is entirely unspecified.
        /// </summary>
        public const string OpenId = "openid";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's <c>allowed_perms</c> and <c>subscribed_perms</c>.
        /// </summary>
        [Todo("Updatate this to correctly reflect the allowed_perms and subscribed_perms. Should we keep the names with _ or with pascal case.")]
        public const string Permission = "urn:oneimlx:scope:perm";

        /// <summary>
        /// This scope value requests access to the <c>phone_number</c> and <c>phone_number_verified</c> claims.
        /// </summary>
        public const string Phone = "phone";

        /// <summary>
        /// This scope value requests access to the End-User's default profile claims, which are: <c>name</c>,
        /// <c>family_name</c>, <c>given_name</c>, <c>middle_name</c>, <c>nickname</c>, <c>preferred_username</c>,
        /// <c>profile</c>, <c>picture</c>, <c>website</c>, <c>gender</c>, <c>birthdate</c>, <c>zoneinfo</c>,
        /// <c>locale</c>, and <c>updated_at</c>.
        /// </summary>
        public const string Profile = "profile";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's <c>allowed_roles</c> and <c>active_role</c>.
        /// </summary>
        [Todo("Updatate this to correctly reflect the allowed_roles and active_role. Should we keep the names with _ or with pascal case.")]
        public const string Role = "role";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's <c>tenant</c> claim.
        /// </summary>
        public const string Tenant = "urn:oneimlx:scope:tenant";

        /// <summary>
        /// This scope value requests access to the Perpetual Intelligence's tenant level claims.
        /// </summary>
        public const string TenantLevels = "urn:oneimlx:scope:tlevels";
    }
}
