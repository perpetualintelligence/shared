/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect client metadata. See <see href="https://openid.net/specs/openid-connect-registration-1_0.html"/> for more information.
    /// </summary>
    [Todo("XML comments missing")]
    public static class ClientMetadata
    {
        public const string RedirectUris = "redirect_uris";
        public const string ResponseTypes = "response_types";
        public const string GrantTypes = "grant_types";
        public const string ApplicationType = "application_type";
        public const string Contacts = "contacts";
        public const string ClientName = "client_name";
        public const string LogoUri = "logo_uri";
        public const string ClientUri = "client_uri";
        public const string PolicyUri = "policy_uri";
        public const string TosUri = "tos_uri";
        public const string JwksUri = "jwks_uri";
        public const string Jwks = "jwks";
        public const string SectorIdentifierUri = "sector_identifier_uri";
        public const string SubjectType = "subject_type";
        public const string TokenEndpointAuthenticationMethod = "token_endpoint_auth_method";
        public const string TokenEndpointAuthenticationSigningAlgorithm = "token_endpoint_auth_signing_alg";
        public const string DefaultMaxAge = "default_max_age";
        public const string RequireAuthenticationTime = "require_auth_time";
        public const string DefaultAcrValues = "default_acr_values";
        public const string InitiateLoginUris = "initiate_login_uri";
        public const string RequestUris = "request_uris";
        public const string IdentityTokenSignedResponseAlgorithm = "id_token_signed_response_alg";
        public const string IdentityTokenEncryptedResponseAlgorithm = "id_token_encrypted_response_alg";
        public const string IdentityTokenEncryptedResponseEncryption = "id_token_encrypted_response_enc";
        public const string UserinfoSignedResponseAlgorithm = "userinfo_signed_response_alg";
        public const string UserInfoEncryptedResponseAlgorithm = "userinfo_encrypted_response_alg";
        public const string UserinfoEncryptedResponseEncryption = "userinfo_encrypted_response_enc";
        public const string RequestObjectSigningAlgorithm = "request_object_signing_alg";
        public const string RequestObjectEncryptionAlgorithm = "request_object_encryption_alg";
        public const string RequestObjectEncryptionEncryption = "request_object_encryption_enc";
    }
}
