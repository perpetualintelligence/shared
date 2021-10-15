/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// Defines the parameters for the OpenID Connect authentication protocol.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html"/>
    [MustDo("TokenType and TokenTypeHint are confusing.")]
    [Todo("Missing XML comments")]
    public static class Parameters
    {
        public const string AccessToken = "access_token";
        public const string AcrValues = "acr_values";
        public const string ActorToken = "actor_token";
        public const string ActorTokenType = "actor_token_type";
        public const string Algorithm = "alg";
        public const string Assertion = "assertion";
        public const string Audience = "audience";
        public const string ClientAssertion = "client_assertion";
        public const string ClientAssertionType = "client_assertion_type";
        public const string ClientId = "client_id";
        public const string ClientIdIssuedAt = "client_id_issued_at";
        public const string ClientSecret = "client_secret";
        public const string ClientSecretExpiresAt = "client_secret_expires_at";
        public const string Code = "code";
        public const string CodeChallenge = "code_challenge";
        public const string CodeChallengeMethod = "code_challenge_method";
        public const string CodeVerifier = "code_verifier";

        // device
        public const string DeviceCode = "device_code";
        public const string Display = "display";
        public const string Error = "error";
        public const string ErrorDescription = "error_description";
        public const string ErrorUri = "error_uri";
        public const string ExpiresIn = "expires_in";
        public const string GrantType = "grant_type";
        public const string IdToken = "id_token";
        public const string IdTokenHint = "id_token_hint";
        public const string Interval = "interval";
        public const string IssuedTokenType = "issued_token_type";
        public const string Issuer = "iss";
        public const string Key = "key";
        public const string LoginHint = "login_hint";
        public const string MaxAge = "max_age";
        public const string Nonce = "nonce";
        public const string Password = "password";
        public const string PostLogoutRedirectUri = "post_logout_redirect_uri";
        public const string Prompt = "prompt";
        public const string RedirectUri = "redirect_uri";
        public const string RefreshToken = "refresh_token";

        // dynamic registration
        public const string RegistrationAccessToken = "registration_access_token";
        public const string RegistrationClientUri = "registration_client_uri";
        public const string Request = "request";
        public const string RequestedTokenType = "requested_token_type";
        public const string RequestId = "request_id";
        public const string RequestUri = "request_uri";
        public const string Resource = "resource";
        public const string ResponseMode = "response_mode";
        public const string ResponseType = "response_type";
        public const string Scope = "scope";
        [MustDo("Why do we need state and session_state", BlockRelease = true)]
        public const string SessionState = "session_state";
        public const string Sid = "sid";
        public const string State = "state";

        // token exchange
        public const string SubjectToken = "subject_token";
        public const string SubjectTokenType = "subject_token_type";
        public const string Token = "token";
        public const string TokenType = "token_type"; // This is Bearer
        public const string TokenTypeHint = "token_type_hint";
        public const string UiLocales = "ui_locales";

        // This is access_token, refresh_token erc...
        public const string UserCode = "user_code";
        public const string UserName = "username";
        public const string VerificationUri = "verification_uri";
        public const string VerificationUriComplete = "verification_uri_complete";
    }
}
