/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The errors for the OAuth and OpenID Connect authentication protocol.
    /// </summary>
    [ToDocumentation("Add std error and explain in which flow they are relevant")]
    [Todo("Missing XML comments")]
    public static class Errors
    {
        /// <summary>
        /// The valid consent errors.
        /// </summary>
        public static string[] ConsentErrors
        {
            get
            {
                return new string[] {
                    AccessDenied,
                    InteractionRequired,
                    LoginRequired,
                    AccountSelectionRequired,
                    ConsentRequired
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

        public const string AccessDenied = "access_denied";
        public const string AccountSelectionRequired = "account_selection_required";
        public const string AuthorizationPending = "authorization_pending";
        public const string ConsentRequired = "consent_required";
        public const string ExpiredToken = "expired_token";
        public const string InsufficientScope = "insufficient_scope";
        public const string InteractionRequired = "interaction_required";
        public const string InvalidClient = "invalid_client";
        public const string InvalidEndpoint = "invalid_endpoint";
        public const string InvalidGrant = "invalid_grant";
        public const string InvalidOrigin = "invalid_origin";
        public const string InvalidRequest = "invalid_request";
        public const string InvalidRequestObject = "invalid_request_object";
        public const string InvalidRequestUri = "invalid_request_uri";
        public const string InvalidScope = "invalid_scope";
        public const string InvalidTarget = "invalid_target";
        public const string InvalidToken = "invalid_token";
        public const string LoginRequired = "login_required";
        public const string MissingToken = "missing_token";
        public const string PolicyViolation = "policy_violation";
        public const string RedirectRequired = "redirect_required";
        public const string RegistrationNotSupported = "registration_not_supported";
        public const string RequestNotSupported = "request_not_supported";
        public const string RequestUriNotSupported = "request_uri_not_supported";
        public const string ServerError = "server_error";
        public const string SlowDown = "slow_down";
        public const string TemporarilyUnavailable = "temporarily_unavailable";
        public const string UnauthorizedClient = "unauthorized_client";
        public const string UnauthorizedOrigin = "unauthorized_origin";
        public const string UnauthorizedSubject = "unauthorized_subject";
        public const string UnexpectedError = "unexpected_error";
        public const string UnexpectedInformation = "unexpected_information";
        public const string UnexpectedWarning = "unexpected_warning";
        public const string UnsupportedGrantType = "unsupported_grant_type";
        public const string UnsupportedResponseType = "unsupported_response_type";
        public const string UnsupportedResponseMode = "unsupported_response_mode";
        public const string UnsupportedTokenType = "unsupported_token_type";
    }
}
