/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OpenID Connect authentication protocol response types.
    /// </summary>
    /// <seealso href="https://openid.net/specs/oauth-v2-multiple-response-types-1_0.html"></seealso>
    public static class ResponseTypes
    {
        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an
        /// authorization <c>code</c>.
        /// </summary>
        public const string Code = "code";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include both
        /// an authorization <c>code</c> and an <c>id_token</c>. The default Response Mode for this Response Type is the
        /// fragment encoding and the query encoding MUST NOT be used. Both successful and error responses SHOULD be
        /// returned using the supplied Response Mode, or if none is supplied, using the default Response Mode.
        /// </summary>
        public const string CodeIdToken = "code id_token";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an
        /// authorization <c>code</c>, an <c>id_token</c>, an <c>access_token</c>, and an <c>access_token</c> Type. The
        /// default Response Mode for this Response Type is the fragment encoding and the query encoding MUST NOT be
        /// used. Both successful and error responses SHOULD be returned using the supplied Response Mode, or if none is
        /// supplied, using the default Response Mode.
        /// </summary>
        public const string CodeIdTokenToken = "code id_token token";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an
        /// <c>access_token</c>, an <c>access_token</c> Type, and an authorization <c>code</c>. The default Response
        /// Mode for this Response Type is the fragment encoding and the query encoding MUST NOT be used. Both
        /// successful and error responses SHOULD be returned using the supplied Response Mode, or if none is supplied,
        /// using the default Response Mode.
        /// </summary>
        public const string CodeToken = "code token";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an <c>id_token</c>.
        /// </summary>
        public const string IdToken = "id_token";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an
        /// <c>access_token</c>, an <c>access_token</c> Type, and an <c>id_token</c>. The default Response Mode for this
        /// Response Type is the fragment encoding and the query encoding MUST NOT be used. Both successful and error
        /// responses SHOULD be returned using the supplied Response Mode, or if none is supplied, using the default
        /// Response Mode.
        /// </summary>
        public const string IdTokenToken = "id_token token";

        /// <summary>
        /// When supplied as the value for the <c>response_type</c> parameter, a successful response MUST include an <c>access_token</c>.
        /// </summary>
        public const string Token = "token";
    }
}
