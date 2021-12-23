/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Defines the parameters for the OAuth or OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
    public static class Parameters
    {
        /// <summary>
        /// The security token issued by the authorization server in response to the token or token-exchange request.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749"/>
        public const string AccessToken = "access_token";

        /// <summary>
        /// The <strong>Authentication Context Class Reference</strong> or <c>acr</c> values. The authorization server
        /// will use it to process an authentication request.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string AcrValues = "acr_values";

        /// <summary>
        /// The security token that represents the identity of the acting party. Typically, this will be the party that
        /// is authorized to use the requested security token and act on behalf of the subject.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
        public const string ActorToken = "actor_token";

        /// <summary>
        /// An identifier that indicates the type of the security token in the <c>actor_token</c> parameter.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
        public const string ActorTokenType = "actor_token_type";

        /// <summary>
        /// The algorithm header parameter values for JWS.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/info/rfc7518"/>
        public const string Algorithm = "alg";

        /// <summary>
        /// An assertion is a package of information that allows identity and security information to be shared across
        /// security domains. An assertion typically contains information about a subject or principal, information
        /// about the party that issued the assertion and when was it issued, and the conditions under which the
        /// assertion is to be considered valid, such as when and where it can be used.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"/>
        public const string Assertion = "assertion";

        /// <summary>
        /// The logical name of the target service where the client intends to use the requested security token.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
        public const string Audience = "audience";

        /// <summary>
        /// The assertion being used to authenticate the client.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"/>
        public const string ClientAssertion = "client_assertion";

        /// <summary>
        /// The format of the assertion as defined by the authorization server. The value will be an absolute URI.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"/>
        public const string ClientAssertionType = "client_assertion_type";

        /// <summary>
        /// The client identifier issued to the client during the registration process.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749"/>
        public const string ClientId = "client_id";

        /// <summary>
        /// The time at which the client identifier was issued. The time is represented as the number of seconds from
        /// <c>1970-01-01T00:00:00Z</c> as measured in UTC until the date/time of issuance.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7591"/>
        public const string ClientIdIssuedAt = "client_id_issued_at";

        /// <summary>
        /// The client secret.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-2.3.1"/>
        public const string ClientSecret = "client_secret";

        /// <summary>
        /// The client secret expiry.
        /// </summary>
        [MustDo("This is not a standard parameter")]
        public const string ClientSecretExpiresAt = "client_secret_expires_at";

        /// <summary>
        /// The authorization code received from the authorization server.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.1.3"/>
        public const string Code = "code";

        /// <summary>
        /// The code challenge.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7636"/>
        public const string CodeChallenge = "code_challenge";

        /// <summary>
        /// The code challenge method.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7636"/>
        public const string CodeChallengeMethod = "code_challenge_method";

        /// <summary>
        /// The code verifier.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7636"/>
        public const string CodeVerifier = "code_verifier";

        /// <summary>
        /// The device verification code.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628#section-3.2"/>
        public const string DeviceCode = "device_code";

        /// <summary>
        /// ASCII string value that specifies how the Authorization Server displays the authentication and consent user
        /// interface pages to the End-User.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string Display = "display";

        /// <summary>
        /// The protocol error code.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string Error = "error";

        /// <summary>
        /// Human-readable ASCII encoded text description of the error.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string ErrorDescription = "error_description";

        /// <summary>
        /// URI of a web page that includes additional information about the error.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string ErrorUri = "error_uri";

        /// <summary>
        /// Expiration time of the Access Token in seconds since the response was generated.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string ExpiresIn = "expires_in";

        /// <summary>
        /// The authorization grant type.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749"/>
        public const string GrantType = "grant_type";

        /// <summary>
        /// ID Token value associated with the authenticated session.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string IdToken = "id_token";

        /// <summary>
        /// ID Token previously issued by the Authorization Server being passed as a hint about the End-User's current
        /// or past authenticated session with the Client.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string IdTokenHint = "id_token_hint";

        /// <summary>
        /// The minimum amount of time in seconds that the client SHOULD wait between polling requests to the token endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
        public const string Interval = "interval";

        /// <summary>
        /// An identifier for the representation of the issued security token.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693#section-2.2.1"/>
        public const string IssuedTokenType = "issued_token_type";

        /// <summary>
        /// The authorization server's issuer identifier, which is a URL that uses the HTTPS scheme and has no query or
        /// fragment components.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/info/rfc8414"/>
        public const string Issuer = "iss";

        /// <summary>
        /// Hint to the Authorization Server about the login identifier the End-User might use to log in (if necessary).
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string LoginHint = "login_hint";

        /// <summary>
        /// The logout Token from the OP for the RP identifying the End-User to be logged out.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-backchannel-1_0.html"/>
        public const string LogoutToken = "logout_token";

        /// <summary>
        /// Maximum Authentication Age. Specifies the allowable elapsed time in seconds since the last time the End-User
        /// was actively authenticated by the OP.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string MaxAge = "max_age";

        /// <summary>
        /// String value used to associate a Client session with an ID Token, and to mitigate replay attacks.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string Nonce = "nonce";

        /// <summary>
        /// The resource owner password.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.3.2"/>
        public const string Password = "password";

        /// <summary>
        /// URL to which the RP is requesting that the End-User's User Agent be redirected after a logout has been performed.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-rpinitiated-1_0.html"/>
        public const string PostLogoutRedirectUri = "post_logout_redirect_uri";

        /// <summary>
        /// Space delimited, case sensitive list of ASCII string values that specifies whether the Authorization Server
        /// prompts the End-User for reauthentication and consent.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string Prompt = "prompt";

        /// <summary>
        /// Redirection URI to which the response will be sent.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string RedirectUri = "redirect_uri";

        /// <summary>
        /// The refresh token, which can be used to obtain new access tokens.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-5.1"/>
        public const string RefreshToken = "refresh_token";

        /// <summary>
        /// Registration Access Token that can be used at the Client Configuration Endpoint to perform subsequent
        /// operations upon the Client registration.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-registration-1_0.html"/>
        public const string RegistrationAccessToken = "registration_access_token";

        /// <summary>
        /// Location of the Client Configuration Endpoint where the Registration Access Token can be used to perform
        /// subsequent operations upon the resulting Client registration.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-registration-1_0.html"/>
        public const string RegistrationClientUri = "registration_client_uri";

        /// <summary>
        /// The Request Object that holds authorization request parameters stated in section 4 of OAuth 2.0.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/id/draft-ietf-oauth-jwsreq-16.html"/>
        public const string Request = "request";

        /// <summary>
        /// An identifier for the type of the requested security token.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
        public const string RequestedTokenType = "requested_token_type";

        /// <summary>
        /// The request identifier.
        /// </summary>
        public const string RequestId = "request_id";

        /// <summary>
        /// The absolute URI as defined by RFC3986 that points to the Request Object that holds authorization request
        /// parameters stated in section 4 of OAuth 2.0.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/id/draft-ietf-oauth-jwsreq-16.html"/>
        public const string RequestUri = "request_uri";

        /// <summary>
        /// Indicates the target service or resource at which access is being requested.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/id/draft-ietf-oauth-resource-indicators-02.html"/>
        public const string Resource = "resource";

        /// <summary>
        /// The response mode determines how the Authorization Server returns result parameters from the Authorization Endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/oauth-v2-multiple-response-types-1_0.html"/>
        public const string ResponseMode = "response_mode";

        /// <summary>
        /// The response type informs the Authorization Server of the desired authorization processing flow, including
        /// what parameters are returned from the endpoints used.
        /// </summary>
        /// <seealso href="https://openid.net/specs/oauth-v2-multiple-response-types-1_0.html"/>
        public const string ResponseType = "response_type";

        /// <summary>
        /// A list of space-delimited, case-sensitive strings, that allow the client to specify the desired scope of the
        /// requested security token in the context of the service or resource where the token will be used.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693"/>
        public const string Scope = "scope";

        /// <summary>
        /// JSON string that represents the End-User's login state at the OP.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-session-1_0.html"/>
        public const string SessionState = "session_state";

        /// <summary>
        /// The session identifier.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-frontchannel-1_0.html"/>
        public const string Sid = "sid";

        /// <summary>
        /// Opaque value used to maintain state between the request and the callback. Typically, Cross-Site Request
        /// Forgery (CSRF, XSRF) mitigation is done by cryptographically binding the value of this parameter with a
        /// browser cookie.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string State = "state";

        /// <summary>
        /// This parameter MUST contain the id_token obtained by the first native app. The id_token is used in the same
        /// manner as id_token_hint to identify the user to SSO into the invoking native app.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-native-sso-1_0.html"/>
        public const string SubjectToken = "subject_token";

        /// <summary>
        /// This parameter MUST contain the value: urn:ietf:params:oauth:token-type:id_token
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-native-sso-1_0.html"/>
        public const string SubjectTokenType = "subject_token_type";

        /// <summary>
        /// The token that the client wants to get revoked.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009"/>
        public const string Token = "token";

        /// <summary>
        /// The token type.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6750"/>
        public const string TokenType = "token_type"; // This is Bearer

        /// <summary>
        /// A hint about the type of the token submitted for revocation.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009"/>
        public const string TokenTypeHint = "token_type_hint";

        /// <summary>
        /// End-User's preferred languages and scripts for the user interface, represented as a space-separated list of
        /// BCP47 [RFC5646] language tag values, ordered by preference.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
        public const string UiLocales = "ui_locales";

        /// <summary>
        /// A secret code, such as a password or pin, that is known only to the user but verifiable by the OP.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html"/>
        public const string UserCode = "user_code";

        /// <summary>
        /// The resource owner username.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.3.2"/>
        public const string UserName = "username";

        /// <summary>
        /// The end-user verification URI on the authorization server.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
        public const string VerificationUri = "verification_uri";

        /// <summary>
        /// A verification URI that includes the "user_code" (or other information with the same function as the
        /// "user_code"), which is designed for non-textual transmission.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
        public const string VerificationUriComplete = "verification_uri_complete";
    }
}
