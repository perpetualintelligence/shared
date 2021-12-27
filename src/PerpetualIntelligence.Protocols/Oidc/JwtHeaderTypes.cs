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
    /// The <c>oneimlx</c> JWT header's <c>type</c> claim for OAuth and OpenID Connect protocols.
    /// </summary>
    public static class JwtHeaderTypes
    {
        /// <summary>
        /// The <c>oneimlx</c> extension for OAuth 2.0 access token.
        /// </summary>
        /// <remarks>
        /// The <see href="https://www.rfc-editor.org/info/rfc9068">RFC9068</see> specification registers the
        /// "application/at+jwt" media type, which can be used to indicate that the content is a JWT access token. JWT
        /// access tokens MUST include this media type in the "typ" header parameter to explicitly declare that the JWT
        /// represents an access token complying with this profile. Per the definition of "typ" in Section 4.1.9 of
        /// [RFC7515], it is RECOMMENDED that the "application/" prefix be omitted. Therefore, the "typ" value used
        /// SHOULD be "at+jwt"
        /// </remarks>
        /// <seealso href="https://www.rfc-editor.org/info/rfc9068"/>
        public const string AccessToken = "at+jwt";

        /// <summary>
        /// The <c>oneimlx</c> extension JWT secured authorization request.
        /// </summary>
        /// <remarks>
        /// The <see href="https://www.rfc-editor.org/info/rfc9101">RFC9101</see> specification registers the
        /// "application/oauth-authz-req+jwt" media type, which can be used to indicate that the content is a JWT
        /// containing Request Object claims. The server should a) check that the value of the "request_uri" parameter
        /// does not point to an unexpected location, b) check that the media type of the response is
        /// "application/oauth-authz-req+jwt", c) implement a timeout for obtaining the content of "request_uri", and d)
        /// not perform recursive GET on the "request_uri".
        /// </remarks>
        /// <seealso href="https://www.rfc-editor.org/info/rfc9101"/>
        public const string AuthorizationRequest = "oauth-authz-req+jwt";
    }
}
