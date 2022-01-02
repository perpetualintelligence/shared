/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OAuth or OpenID Connect client meta-data.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-registration-1_0.html"/>
    public static class ClientMetadata
    {
        /// <summary>
        /// The kind of application.
        /// </summary>
        /// <seealso cref="Applications"/>
        public const string ApplicationType = "application_type";

        /// <summary>
        /// Name of the Client to be presented to the End-User.
        /// </summary>
        public const string ClientName = "client_name";

        /// <summary>
        /// URL of the home page of the Client.
        /// </summary>
        public const string ClientUri = "client_uri";

        /// <summary>
        /// Array of e-mail addresses of people responsible for this Client.
        /// </summary>
        public const string Contacts = "contacts";

        /// <summary>
        /// Default requested Authentication Context Class Reference values.
        /// </summary>
        public const string DefaultAcrValues = "default_acr_values";

        /// <summary>
        /// Default Maximum Authentication Age. Specifies that the End-User MUST be actively authenticated if the
        /// End-User was authenticated longer ago than the specified number of seconds.
        /// </summary>
        public const string DefaultMaxAge = "default_max_age";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 Grant Types that the Client is declaring that it will restrict
        /// itself to using.
        /// </summary>
        public const string GrantTypes = "grant_types";

        /// <summary>
        /// JWE alg algorithm [JWA] REQUIRED for encrypting the ID Token issued to this Client.
        /// </summary>
        public const string IdTokenEncryptedResponseAlgorithm = "id_token_encrypted_response_alg";

        /// <summary>
        /// JWE enc algorithm [JWA] REQUIRED for encrypting the ID Token issued to this Client.
        /// </summary>
        public const string IdTokenEncryptedResponseEncryption = "id_token_encrypted_response_enc";

        /// <summary>
        /// JWS alg algorithm [JWA] REQUIRED for signing the ID Token issued to this Client.
        /// </summary>
        public const string IdTokenSignedResponseAlgorithm = "id_token_signed_response_alg";

        /// <summary>
        /// URI using the https scheme that a third party can use to initiate a login by the RP.
        /// </summary>
        public const string InitiateLoginUris = "initiate_login_uri";

        /// <summary>
        /// Client's JSON Web Key Set [JWK] document, passed by value.
        /// </summary>
        public const string Jwks = "jwks";

        /// <summary>
        /// URL for the Client's JSON Web Key Set [JWK] document.
        /// </summary>
        public const string JwksUri = "jwks_uri";

        /// <summary>
        /// URL that references a logo for the Client application.
        /// </summary>
        public const string LogoUri = "logo_uri";

        /// <summary>
        /// URL that the Relying Party Client provides to the End-User to read about the how the profile data will be used.
        /// </summary>
        public const string PolicyUri = "policy_uri";

        /// <summary>
        /// Array of Redirection URI values used by the Client.
        /// </summary>
        public const string RedirectUris = "redirect_uris";

        /// <summary>
        /// JWE [JWE] alg algorithm [JWA] the RP is declaring that it may use for encrypting Request Objects sent to the OP.
        /// </summary>
        public const string RequestObjectEncryptionAlgorithm = "request_object_encryption_alg";

        /// <summary>
        /// JWE [JWE] alg algorithm [JWA] the RP is declaring that it may use for encrypting Request Objects sent to the OP.
        /// </summary>
        public const string RequestObjectEncryptionEncryption = "request_object_encryption_enc";

        /// <summary>
        /// JWS [JWS] alg algorithm [JWA] that MUST be used for signing Request Objects sent to the OP.
        /// </summary>
        public const string RequestObjectSigningAlgorithm = "request_object_signing_alg";

        /// <summary>
        /// Array of request_uri values that are pre-registered by the RP for use at the OP.
        /// </summary>
        public const string RequestUris = "request_uris";

        /// <summary>
        /// Boolean value specifying whether the auth_time Claim in the ID Token is REQUIRED.
        /// </summary>
        public const string RequireAuthenticationTime = "require_auth_time";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 response_type values that the Client is declaring that it will
        /// restrict itself to using.
        /// </summary>
        public const string ResponseTypes = "response_types";

        /// <summary>
        /// URL using the https scheme to be used in calculating Pseudonymous Identifiers by the OP.
        /// </summary>
        public const string SectorIdentifierUri = "sector_identifier_uri";

        /// <summary>
        /// subject_type requested for responses to this Client.
        /// </summary>
        public const string SubjectType = "subject_type";

        /// <summary>
        /// Requested Client Authentication method for the Token Endpoint.
        /// </summary>
        public const string TokenEndpointAuthenticationMethod = "token_endpoint_auth_method";

        /// <summary>
        /// JWS alg algorithm [JWA] that MUST be used for signing the JWT [JWT] used to authenticate the Client at the
        /// Token Endpoint for the private_key_jwt and client_secret_jwt authentication methods.
        /// </summary>
        public const string TokenEndpointAuthenticationSigningAlgorithm = "token_endpoint_auth_signing_alg";

        /// <summary>
        /// URL that the Relying Party Client provides to the End-User to read about the Relying Party's terms of service.
        /// </summary>
        public const string TosUri = "tos_uri";

        /// <summary>
        /// JWE alg algorithm [JWA] REQUIRED for encrypting UserInfo Responses.
        /// </summary>
        public const string UserInfoEncryptedResponseAlgorithm = "userinfo_encrypted_response_alg";

        /// <summary>
        /// JWE enc algorithm [JWA] REQUIRED for encrypting UserInfo Responses.
        /// </summary>
        public const string UserinfoEncryptedResponseEncryption = "userinfo_encrypted_response_enc";

        /// <summary>
        /// JWS alg algorithm [JWA] REQUIRED for signing UserInfo Responses.
        /// </summary>
        public const string UserinfoSignedResponseAlgorithm = "userinfo_signed_response_alg";
    }
}
