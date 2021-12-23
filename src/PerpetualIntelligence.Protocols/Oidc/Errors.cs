/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The errors for the OAuth and OpenID Connect authentication protocol.
    /// </summary>
    public static class Errors
    {
        /// <summary>
        /// The valid authentication errors.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public static string[] AuthenticationErrors
        {
            get
            {
                return new string[] {
                    InteractionRequired,
                    LoginRequired,
                    AccountSelectionRequired,
                    ConsentRequired,
                    InvalidRequestUri,
                    InvalidRequestObject,
                    RequestNotSupported,
                    RequestUriNotSupported,
                    RegistrationNotSupported
                };
            }
        }

        /// <summary>
        /// The valid authorization errors.
        /// </summary>
        public static string[] AuthorizationErrors
        {
            get
            {
                return new string[] {
                    AccessDenied,
                    InteractionRequired,
                    LoginRequired,
                    AccountSelectionRequired,
                    ConsentRequired,
                    TemporarilyUnavailable
                };
            }
        }

        /// <summary>
        /// The valid token errors.
        /// </summary>
        public static string[] TokenErrors
        {
            get
            {
                return new string[] {
                    InvalidRequest,
                    InvalidClient,
                    InvalidGrant,
                    UnauthorizedClient,
                    UnsupportedGrantType,
                    InvalidScope,
                    InvalidTarget
                };
            }
        }

        /// <summary>
        /// The resource owner or authorization server denied the request.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.1.2.1"/>
        public const string AccessDenied = "access_denied";

        /// <summary>
        /// The End-User is REQUIRED to select a session at the Authorization Server. The End-User MAY be authenticated
        /// at the Authorization Server with different associated accounts, but the End-User did not select a session.
        /// This error MAY be returned when the prompt parameter value in the Authentication Request is none, but the
        /// Authentication Request cannot be completed without displaying a user interface to prompt for a session to use.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string AccountSelectionRequired = "account_selection_required";

        /// <summary>
        /// The authorization request is still pending as the end-user hasn't yet been authenticated.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string AuthorizationPending = "authorization_pending";

        /// <summary>
        /// The Authorization Server requires End-User consent. This error MAY be returned when the prompt parameter
        /// value in the Authentication Request is none, but the Authentication Request cannot be completed without
        /// displaying a user interface for End-User consent.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string ConsentRequired = "consent_required";

        /// <summary>
        /// The <c>auth_req_id</c> has expired. The Client will need to make a new Authentication Request.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string ExpiredToken = "expired_token";
        public const string InsufficientScope = "insufficient_scope";
        public const string InteractionRequired = "interaction_required";
        public const string InvalidClient = "invalid_client";
        public const string InvalidEndpoint = "invalid_endpoint";
        public const string InvalidGrant = "invalid_grant";
        public const string InvalidOrigin = "invalid_origin";
        public const string InvalidRequest = "invalid_request";

        /// <summary>
        /// The <c>request</c> parameter contains an invalid Request Object.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string InvalidRequestObject = "invalid_request_object";

        /// <summary>
        /// The <c>request_uri</c> in the Authorization Request returns an error or contains invalid data.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string InvalidRequestUri = "invalid_request_uri";
        public const string InvalidScope = "invalid_scope";
        public const string InvalidTarget = "invalid_target";
        public const string InvalidToken = "invalid_token";
        public const string LoginRequired = "login_required";
        public const string MissingToken = "missing_token";
        public const string PolicyViolation = "policy_violation";
        public const string RedirectRequired = "redirect_required";

        /// <summary>
        /// The OP does not support use of the <c>registration</c> parameter.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string RegistrationNotSupported = "registration_not_supported";

        /// <summary>
        /// The OP does not support use of the <c>request</c> parameter
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string RequestNotSupported = "request_not_supported";

        /// <summary>
        /// The OP does not support use of the <c>request_uri</c> parameter.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string RequestUriNotSupported = "request_uri_not_supported";
        public const string ServerError = "server_error";

        /// <summary>
        /// A variant of <c>authorization_pending</c>, the authorization request is still pending and polling should
        /// continue, but the interval MUST be increased by at least 5 seconds for this and all subsequent requests.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string SlowDown = "slow_down";
        public const string TemporarilyUnavailable = "temporarily_unavailable";

        /// <summary>
        /// The OpenID Provider encountered an unexpected condition that prevented it from successfully completing the
        /// transaction. This general case error code can be used to inform the Client that the CIBA transaction was
        /// unsuccessful for reasons other than those explicitly defined by access_denied and expired_token.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string TransactionFailed = "transaction_failed";
        public const string UnauthorizedClient = "unauthorized_client";
        public const string UnauthorizedOrigin = "unauthorized_origin";
        public const string UnauthorizedSubject = "unauthorized_subject";
        public const string UnexpectedError = "unexpected_error";
        public const string UnexpectedInformation = "unexpected_information";
        public const string UnexpectedWarning = "unexpected_warning";
        public const string UnsupportedGrantType = "unsupported_grant_type";
        public const string UnsupportedResponseMode = "unsupported_response_mode";
        public const string UnsupportedResponseType = "unsupported_response_type";
        public const string UnsupportedTokenType = "unsupported_token_type";
    }
}
