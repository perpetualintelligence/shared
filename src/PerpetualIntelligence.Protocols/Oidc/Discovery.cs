/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OpenID Connect discovery metadata. See
    /// <see href="https://openid.net/specs/openid-connect-discovery-1_0.html"/> for more information.
    /// </summary>
    public static class Discovery
    {
        /// <summary>
        /// JSON array containing a list of the Authentication Context Class References that this OP supports.
        /// </summary>
        public const string AcrValuesSupported = "acr_values_supported";

        /// <summary>
        /// URL of the OP's OAuth 2.0 Authorization Endpoint.
        /// </summary>
        public const string AuthorizationEndpoint = "authorization_endpoint";

        /// <summary>
        /// Authorization servers supporting this specification MUST provide their issuer identifier to enable clients
        /// to validate the <c>iss</c> parameter effectively. See
        /// <see href="https://tools.ietf.org/id/draft-meyerzuselhausen-oauth-iss-auth-resp-02.html"/> for more information.
        /// </summary>
        public const string AuthorizationResponseIssParameterSupported = "authorization_response_iss_parameter_supported";

        /// <summary>
        /// Boolean value specifying whether the OP can pass a sid (session ID) Claim in the Logout Token to identify
        /// the RP session with the OP. If supported, the sid Claim is also included in ID Tokens issued by the OP. If
        /// omitted, the default value is false. See
        /// <see href="https://openid.net/specs/openid-connect-backchannel-1_0.html"/> for more information.
        /// </summary>
        public const string BackChannelLogoutSessionSupported = "backchannel_logout_session_supported";

        /// <summary>
        /// Boolean value specifying whether the OP supports back-channel logout, with true indicating support. If
        /// omitted, the default value is false. See
        /// <see href="https://openid.net/specs/openid-connect-backchannel-1_0.html"/> for more information.
        /// </summary>
        public const string BackChannelLogoutSupported = "backchannel_logout_supported";

        /// <summary>
        /// URL of an OP <c>iframe</c> that supports cross-origin communications for session state information with the
        /// RP Client, using the HTML5 postMessage API. This URL MUST use the <c>https</c> scheme and MAY contain port,
        /// path, and query parameter components. The page is loaded from an invisible <c>iframe</c> embedded in an RP
        /// page so that it can run in the OP's security context. It accepts postMessage requests from the relevant RP
        /// <c>iframe</c> and uses postMessage to post back the login status of the End-User at the OP. See
        /// <see href="https://openid.net/specs/openid-connect-session-1_0.html"/> for more information.
        /// </summary>
        public const string CheckSessionIframe = "check_session_iframe";

        /// <summary>
        /// Languages and scripts supported for values in Claims being returned, represented as a JSON array of BCP47
        /// [RFC5646] language tag values. Not all languages and scripts are necessarily supported for all Claim values.
        /// </summary>
        public const string ClaimsLocalesSupported = "claims_locales_supported";

        /// <summary>
        /// Boolean value specifying whether the OP supports use of the claims parameter, with true indicating support.
        /// If omitted, the default value is false.
        /// </summary>
        public const string ClaimsParameterSupported = "claims_parameter_supported";

        /// <summary>
        /// JSON array containing a list of the Claim Names of the Claims that the OpenID Provider MAY be able to supply
        /// values for. Note that for privacy or other reasons, this might not be an exhaustive list.
        /// </summary>
        public const string ClaimsSupported = "claims_supported";

        /// <summary>
        /// JSON array containing a list of the Claim Types that the OpenID Provider supports. These Claim Types are
        /// described in Section 5.6 of OpenID Connect Core 1.0 [OpenID.Core]. Values defined by this specification are
        /// normal, aggregated, and distributed. If omitted, the implementation supports only normal Claims.
        /// </summary>
        public const string ClaimTypesSupported = "claim_types_supported";

        /// <summary>
        /// JSON array containing a list of code challenge as part of the OAuth 2.0 Authorization Request. See
        /// <see href="https://datatracker.ietf.org/doc/html/rfc7636"/> for more information.
        /// </summary>
        public const string CodeChallengeMethodsSupported = "code_challenge_methods_supported";

        /// <summary>
        /// URL of the OP's OAuth 2.0 Device Authorization Endpoint. See
        /// <see href="https://datatracker.ietf.org/doc/html/rfc8628"/> for more information.
        /// </summary>
        public const string DeviceAuthorizationEndpoint = "device_authorization_endpoint";

        /// <summary>
        /// JSON document containing well known configuration that the OpenID Provider supports.
        /// </summary>
        public const string DiscoveryEndpoint = ".well-known/openid-configuration";

        /// <summary>
        /// JSON array containing a list of the display parameter values that the OpenID Provider supports. These values
        /// are described in Section 3.1.2.1 of OpenID Connect Core 1.0 [OpenID.Core].
        /// </summary>
        public const string DisplayValuesSupported = "display_values_supported";

        /// <summary>
        /// URL at the OP to which an RP can perform a redirect to request that the End-User be logged out at the OP.
        /// See <see href="https://openid.net/specs/openid-connect-session-1_0.html"/> for more information.
        /// </summary>
        public const string EndSessionEndpoint = "end_session_endpoint";

        /// <summary>
        /// Boolean value specifying whether the OP can pass iss (issuer) and sid (session ID) query parameters to
        /// identify the RP session with the OP when the frontchannel_logout_uri is used. If supported, the sid Claim is
        /// also included in ID Tokens issued by the OP. If omitted, the default value is false. See
        /// <see href="https://openid.net/specs/openid-connect-frontchannel-1_0.html"/> for more information.
        /// </summary>
        public const string FrontChannelLogoutSessionSupported = "frontchannel_logout_session_supported";

        /// <summary>
        /// Boolean value specifying whether the OP supports HTTP-based logout, with true indicating support. If
        /// omitted, the default value is false. See
        /// <see href="https://openid.net/specs/openid-connect-frontchannel-1_0.html"/> for more information.
        /// </summary>
        public const string FrontChannelLogoutSupported = "frontchannel_logout_supported";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 Grant Type values that this OP supports. Dynamic OpenID
        /// Providers MUST support the authorization_code and implicit Grant Type values and MAY support other Grant
        /// Types. If omitted, the default value is ["authorization_code", "implicit"].
        /// </summary>
        public const string GrantTypesSupported = "grant_types_supported";

        /// <summary>
        /// JSON array containing a list of the JWE encryption algorithms (alg values) supported by the OP for the ID
        /// Token to encode the Claims in a JWT [JWT].
        /// </summary>
        public const string IdTokenEncryptionAlgorithmsSupported = "id_token_encryption_alg_values_supported";

        /// <summary>
        /// JSON array containing a list of the JWE encryption algorithms (enc values) supported by the OP for the ID
        /// Token to encode the Claims in a JWT [JWT].
        /// </summary>
        public const string IdTokenEncryptionEncValuesSupported = "id_token_encryption_enc_values_supported";

        /// <summary>
        /// JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for the ID Token
        /// to encode the Claims in a JWT [JWT]. The algorithm RS256 MUST be included. The value none MAY be supported,
        /// but MUST NOT be used unless the Response Type used returns no ID Token from the Authorization Endpoint (such
        /// as when using the Authorization Code Flow).
        /// </summary>
        public const string IdTokenSigningAlgorithmsSupported = "id_token_signing_alg_values_supported";

        /// <summary>
        /// URL of the OAuth 2.0 Token Introspection Endpoint. See
        /// <see href="https://datatracker.ietf.org/doc/html/rfc7662"/> for more information.
        /// </summary>
        public const string IntrospectionEndpoint = "introspection_endpoint";

        /// <summary>
        /// URL using the <c>https</c> scheme with no <c>query</c> or <c>fragment</c> component that the OP asserts as
        /// its Issuer Identifier. If Issuer discovery is supported (see Section 2), this value MUST be identical to the
        /// issuer value returned by WebFinger. This also MUST be identical to the <c>iss</c> Claim value in ID Tokens
        /// issued from this Issuer.
        /// </summary>
        public const string Issuer = "issuer";

        /// <summary>
        /// URL of the OP's JSON Web Key Set [JWK] document. This contains the signing key(s) the RP uses to validate
        /// signatures from the OP. The JWK Set MAY also contain the Server's encryption key(s), which are used by RPs
        /// to encrypt requests to the Server. When both signing and encryption keys are made available, a use (Key Use)
        /// parameter value is REQUIRED for all keys in the referenced JWK Set to indicate each key's intended usage.
        /// Although some algorithms allow the same key to be used for both signatures and encryption, doing so is NOT
        /// RECOMMENDED, as it is less secure. The JWK x5c parameter MAY be used to provide X.509 representations of
        /// keys provided. When used, the bare key values MUST still be present and MUST match those in the certificate.
        /// </summary>
        public const string JwksUri = "jwks_uri";

        /// <summary>
        /// A JSON object containing alternative authorization server endpoints that, when present, an OAuth client
        /// intending to do mutual TLS uses in preference to the conventional endpoints. The parameter value itself
        /// consists of one or more endpoint parameters, such as "token_endpoint", "revocation_endpoint",
        /// "introspection_endpoint", etc., conventionally defined for the top level of authorization server metadata.An
        /// OAuth client intending to do mutual TLS(for OAuth client authentication and/or to acquire or use
        /// certificate-bound tokens) when making a request directly to the authorization server MUST use the alias URL
        /// of the endpoint within the "mtls_endpoint_aliases", when present, in preference to the endpoint URL of the
        /// same name at the top level of metadata.When an endpoint is not present in "mtls_endpoint_aliases", then the
        /// client uses the conventional endpoint URL defined at the top level of the authorization server
        /// metadata.Metadata parameters within "mtls_endpoint_aliases" that do not define endpoints to which an OAuth
        /// client makes a direct request have no meaning and SHOULD be ignored. /// See
        /// <see href="https://datatracker.ietf.org/doc/html/rfc8705"/> for more information.
        /// </summary>
        public const string MtlsEndpointAliases = "mtls_endpoint_aliases";

        /// <summary>
        /// URL that the OpenID Provider provides to the person registering the Client to read about the OP's
        /// requirements on how the Relying Party can use the data provided by the OP. The registration process SHOULD
        /// display this URL to the person registering the Client if it is given.
        /// </summary>
        public const string OpPolicyUri = "op_policy_uri";

        /// <summary>
        /// URL that the OpenID Provider provides to the person registering the Client to read about OpenID Provider's
        /// terms of service. The registration process SHOULD display this URL to the person registering the Client if
        /// it is given.
        /// </summary>
        public const string OpTosUri = "op_tos_uri";

        /// <summary>
        /// URL of the OP's Dynamic Client Registration Endpoint.
        /// </summary>
        public const string RegistrationEndpoint = "registration_endpoint";

        /// <summary>
        /// JSON array containing a list of the JWE encryption algorithms (alg values) supported by the OP for Request
        /// Objects. These algorithms are used both when the Request Object is passed by value and when it is passed by reference.
        /// </summary>
        public const string RequestObjectEncryptionAlgorithmsSupported = "request_object_encryption_alg_values_supported";

        /// <summary>
        /// JSON array containing a list of the JWE encryption algorithms (enc values) supported by the OP for Request
        /// Objects. These algorithms are used both when the Request Object is passed by value and when it is passed by reference.
        /// </summary>
        public const string RequestObjectEncryptionEncValuesSupported = "request_object_encryption_enc_values_supported";

        /// <summary>
        /// JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for Request
        /// Objects, which are described in Section 6.1 of OpenID Connect Core 1.0 [OpenID.Core]. These algorithms are
        /// used both when the Request Object is passed by value (using the request parameter) and when it is passed by
        /// reference (using the request_uri parameter). Servers SHOULD support none and RS256.
        /// </summary>
        public const string RequestObjectSigningAlgorithmsSupported = "request_object_signing_alg_values_supported";

        /// <summary>
        /// Boolean value specifying whether the OP supports use of the request parameter, with true indicating support.
        /// If omitted, the default value is false.
        /// </summary>
        public const string RequestParameterSupported = "request_parameter_supported";

        /// <summary>
        /// Boolean value specifying whether the OP supports use of the request_uri parameter, with true indicating
        /// support. If omitted, the default value is true.
        /// </summary>
        public const string RequestUriParameterSupported = "request_uri_parameter_supported";

        /// <summary>
        /// Boolean value specifying whether the OP requires any request_uri values used to be pre-registered using the
        /// request_uris registration parameter. Pre-registration is REQUIRED when the value is true. If omitted, the
        /// default value is false.
        /// </summary>
        public const string RequireRequestUriRegistration = "require_request_uri_registration";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 <c>response_mode</c> values that this OP supports, as
        /// specified in OAuth 2.0 Multiple Response Type Encoding Practices[OAuth.Responses]. If omitted, the default
        /// for Dynamic OpenID Providers is ["query", "fragment"].
        /// </summary>
        public const string ResponseModesSupported = "response_modes_supported";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 <c>response_type</c> values that this OP supports. Dynamic
        /// OpenID Providers MUST support the <c>code</c> , <c>id_token</c>, and the <c>token</c><c>id_token</c>
        /// Response Type values.
        /// </summary>
        public const string ResponseTypesSupported = "response_types_supported";

        /// <summary>
        /// URL of the OAuth 2.0 Token Revocation endpoint. See
        /// <see href="https://datatracker.ietf.org/doc/html/rfc7009"/> for more information.
        /// </summary>
        public const string RevocationEndpoint = "revocation_endpoint";

        /// <summary>
        /// JSON array containing a list of the OAuth 2.0 [RFC6749] scope values that this server supports. The server
        /// MUST support the <c>openid</c> scope value. Servers MAY choose not to advertise some supported scope values
        /// even when this parameter is used, although those defined in [OpenID.Core] SHOULD be listed, if supported.
        /// </summary>
        public const string ScopesSupported = "scopes_supported";

        /// <summary>
        /// URL of a page containing human-readable information that developers might want or need to know when using
        /// the OpenID Provider. In particular, if the OpenID Provider does not support Dynamic Client Registration,
        /// then information on how to register Clients needs to be provided in this documentation.
        /// </summary>
        public const string ServiceDocumentation = "service_documentation";

        /// <summary>
        /// JSON array containing a list of the Subject Identifier types that this OP supports. Valid types include
        /// pairwise and public.
        /// </summary>
        public const string SubjectTypesSupported = "subject_types_supported";

        /// <summary>
        /// Boolean value indicating server support for mutual-TLS client certificate-bound access tokens.If omitted,
        /// the default value is "false". <see href="https://datatracker.ietf.org/doc/html/rfc8705"/> for more information.
        /// </summary>
        public const string TlsClientCertificateBoundAccessTokens = "tls_client_certificate_bound_access_tokens";

        /// <summary>
        /// URL of the OP's OAuth 2.0 Token Endpoint.
        /// </summary>
        public const string TokenEndpoint = "token_endpoint";

        /// <summary>
        /// JSON array containing a list of Client Authentication methods supported by this Token Endpoint. The options
        /// are client_secret_post, client_secret_basic, client_secret_jwt, and private_key_jwt, as described in Section
        /// 9 of OpenID Connect Core 1.0 [OpenID.Core]. Other authentication methods MAY be defined by extensions. If
        /// omitted, the default is client_secret_basic -- the HTTP Basic Authentication Scheme specified in Section
        /// 2.3.1 of OAuth 2.0 [RFC6749].
        /// </summary>
        public const string TokenEndpointAuthenticationMethodsSupported = "token_endpoint_auth_methods_supported";

        /// <summary>
        /// JSON array containing a list of the JWS signing algorithms (alg values) supported by the Token Endpoint for
        /// the signature on the JWT [JWT] used to authenticate the Client at the Token Endpoint for the private_key_jwt
        /// and client_secret_jwt authentication methods. Servers SHOULD support RS256. The value none MUST NOT be used.
        /// </summary>
        public const string TokenEndpointAuthSigningAlgorithmsSupported = "token_endpoint_auth_signing_alg_values_supported";

        /// <summary>
        /// Languages and scripts supported for the user interface, represented as a JSON array of BCP47 [RFC5646]
        /// language tag values.
        /// </summary>
        public const string UILocalesSupported = "ui_locales_supported";

        /// <summary>
        /// JSON array containing a list of the JWE [JWE] encryption algorithms (alg values) [JWA] supported by the
        /// UserInfo Endpoint to encode the Claims in a JWT [JWT].
        /// </summary>
        public const string UserInfoEncryptionAlgorithmsSupported = "userinfo_encryption_alg_values_supported";

        /// <summary>
        /// JSON array containing a list of the JWE encryption algorithms (enc values) [JWA] supported by the UserInfo
        /// Endpoint to encode the Claims in a JWT [JWT].
        /// </summary>
        public const string UserInfoEncryptionEncValuesSupported = "userinfo_encryption_enc_values_supported";

        /// <summary>
        /// URL of the OP's UserInfo Endpoint.
        /// </summary>
        public const string UserInfoEndpoint = "userinfo_endpoint";

        /// <summary>
        /// JSON array containing a list of the JWS [JWS] signing algorithms (alg values) [JWA] supported by the
        /// UserInfo Endpoint to encode the Claims in a JWT [JWT]. The value none MAY be included.
        /// </summary>
        public const string UserInfoSigningAlgorithmsSupported = "userinfo_signing_alg_values_supported";
    }
}
