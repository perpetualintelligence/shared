/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;

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
        /// <value>
        /// An array of authentication errors that includes <see cref="InteractionRequired"/>,
        /// <see cref="LoginRequired"/>, <see cref="AccountSelectionRequired"/>, <see cref="ConsentRequired"/>,
        /// <see cref="InvalidRequestUri"/>, <see cref="InvalidRequestObject"/>, <see cref="RequestNotSupported"/>,
        /// <see cref="RequestUriNotSupported"/>, <see cref="RegistrationNotSupported"/>.
        /// </value>
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
        /// <value>
        /// An array of authorization errors that includes <see cref="AccessDenied"/>,
        /// <see cref="InteractionRequired"/>, <see cref="LoginRequired"/>, <see cref="AccountSelectionRequired"/>,
        /// <see cref="ConsentRequired"/>, <see cref="TemporarilyUnavailable"/>.
        /// </value>
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
        /// <value>
        /// An array of token errors that includes <see cref="InvalidRequest"/>, <see cref="InvalidClient"/>,
        /// <see cref="InvalidGrant"/>, <see cref="UnauthorizedClient"/>, <see cref="UnsupportedGrantType"/>,
        /// <see cref="InvalidScope"/>, <see cref="InvalidTarget"/>.
        /// </value>
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

        /// <summary>
        /// The request requires higher privileges than provided by the access token.
        /// </summary>
        /// <seealso href="https://tools.ietf.org/id/draft-ietf-oauth-v2-bearer-20.html#resource-error-codes"/>
        public const string InsufficientScope = "insufficient_scope";

        /// <summary>
        /// The Authorization Server requires End-User interaction of some form to proceed. This error MAY be returned
        /// when the prompt parameter value in the Authentication Request is none, but the Authentication Request cannot
        /// be completed without displaying a user interface for End-User interaction.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string InteractionRequired = "interaction_required";

        /// <summary>
        /// Client authentication failed (e.g., unknown client, no client authentication included, or unsupported
        /// authentication method). The authorization server MAY return an HTTP 401 (Unauthorized) status code to
        /// indicate which HTTP authentication schemes are supported.If the client attempted to authenticate via the
        /// "Authorization" request header field, the authorization server MUST respond with an HTTP 401 (Unauthorized)
        /// status code and include the "WWW-Authenticate" response header field matching the authentication scheme used
        /// by the client.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/rfc/rfc6749#section-5.2"/>
        public const string InvalidClient = "invalid_client";

        /// <summary>
        /// Endpoint routing failed (e.g. unknown endpoint, no endpoint identity specified, endpoint belong to different
        /// authority, unsupported endpoint, or invalid endpoint URL).
        /// </summary>
        public const string InvalidEndpoint = "invalid_endpoint";

        /// <summary>
        /// The provided authorization grant (e.g., authorization code, resource owner credentials) or refresh token is
        /// invalid, expired, revoked, does not match the redirection URI used in the authorization request, or was
        /// issued to another client.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-5.2"/>
        public const string InvalidGrant = "invalid_grant";

        /// <summary>
        /// The requested origin is not an OP trusted origin.
        /// </summary>
        public const string InvalidOrigin = "invalid_origin";

        /// <summary>
        /// The request is missing a required parameter, includes an invalid parameter value, includes a parameter more
        /// than once, or is otherwise malformed.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/rfc/rfc6749#section-5.2"/>
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

        /// <summary>
        /// The requested scope is invalid, unknown, or malformed.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/rfc/rfc6749#section-5.2"/>
        public const string InvalidScope = "invalid_scope";

        /// <summary>
        /// The requested resource is invalid, missing, unknown, or malformed.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/info/rfc8707"/>
        public const string InvalidTarget = "invalid_target";

        /// <summary>
        /// The access token provided is expired, revoked, malformed, or invalid for other reasons.The resource SHOULD
        /// respond with the HTTP 401 (Unauthorized) status code.The client MAY request a new access token and retry the
        /// protected resource request.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6750#section-3.1"/>
        public const string InvalidToken = "invalid_token";

        /// <summary>
        /// The Authorization Server requires End-User authentication. This error MAY be returned when the prompt
        /// parameter value in the Authentication Request is none, but the Authentication Request cannot be completed
        /// without displaying a user interface for End-User authentication.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#AuthError"/>
        public const string LoginRequired = "login_required";

        /// <summary>
        /// The token is missing during introspection.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7662.html"/>
        public const string MissingToken = "missing_token";

        /// <summary>
        /// The OpenID Connect discovery policy violation.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-discovery-1_0.html"/>
        [MustDo("non standard error")]
        public const string PolicyViolation = "policy_violation";

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

        /// <summary>
        /// The authorization server encountered an unexpected condition that prevented it from fulfilling the request.
        /// (This error code is needed because a 500 Internal Server Error HTTP status code cannot be returned to the
        /// client via an HTTP redirect.)
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.1.2.1"/>
        public const string ServerError = "server_error";

        /// <summary>
        /// A variant of <c>authorization_pending</c>, the authorization request is still pending and polling should
        /// continue, but the interval MUST be increased by at least 5 seconds for this and all subsequent requests.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string SlowDown = "slow_down";

        /// <summary>
        /// The authorization server is currently unable to handle the request due to a temporary overloading or
        /// maintenance of the server. (This error code is needed because a 503 Service Unavailable HTTP status code
        /// cannot be returned to the client via an HTTP redirect.)
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string TemporarilyUnavailable = "temporarily_unavailable";

        /// <summary>
        /// The OpenID Provider encountered an unexpected condition that prevented it from successfully completing the
        /// transaction. This general case error code can be used to inform the Client that the CIBA transaction was
        /// unsuccessful for reasons other than those explicitly defined by access_denied and expired_token.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html#rfc.section.11"/>
        public const string TransactionFailed = "transaction_failed";

        /// <summary>
        /// The client is not authorized to request an authorization code or use a grant type.
        /// </summary>
        /// <seealso href="https://www.rfc-editor.org/rfc/rfc6749#section-4.2.2.1"/>
        public const string UnauthorizedClient = "unauthorized_client";

        /// <summary>
        /// The origin is not a trusted origin or not allowed by the authorization server.
        /// </summary>
        public const string UnauthorizedOrigin = "unauthorized_origin";

        /// <summary>
        /// The subject is not authorized or the subject is disabled.
        /// </summary>
        public const string UnauthorizedSubject = "unauthorized_subject";

        /// <summary>
        /// An unexpected error.
        /// </summary>
        public const string UnexpectedError = "unexpected_error";

        /// <summary>
        /// An unexpected information.
        /// </summary>
        public const string UnexpectedInformation = "unexpected_information";

        /// <summary>
        /// An unexpected warning.
        /// </summary>
        public const string UnexpectedWarning = "unexpected_warning";

        /// <summary>
        /// The authorization grant type is not supported by the authorization server.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-5.2"/>
        public const string UnsupportedGrantType = "unsupported_grant_type";

        /// <summary>
        /// The authorization server does not support obtaining an access token using this method.
        /// </summary>
        /// <seealso href="https://openid.net/specs/oauth-v2-multiple-response-types-1_0.html"/>
        /// <seealso href="https://openid.net/specs/oauth-v2-form-post-response-mode-1_0.html"/>
        public const string UnsupportedResponseMode = "unsupported_response_mode";

        /// <summary>
        /// The authorization server does not support obtaining an access token using this method.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.2.2.1"/>
        public const string UnsupportedResponseType = "unsupported_response_type";

        /// <summary>
        /// The authorization server does not support the revocation of the presented token type.That is, the client
        /// tried to revoke an access token on a server not supporting this feature.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009"/>
        public const string UnsupportedTokenType = "unsupported_token_type";
    }
}
