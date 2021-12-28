/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The client authentication methods for OAuth or OpenID Connect client authentication.
    /// </summary>
    public static class ClientAuthenticationMethods
    {
        /// <summary>
        /// The client uses HTTP Basic as defined in OAuth 2.0.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#ClientAuthentication"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7591#section-2"/>
        public const string Basic = "client_secret_basic";

        /// <summary>
        /// The client uses the HTTP POST parameters as defined in OAuth 2.0.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#ClientAuthentication"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7591#section-2"/>
        public const string PostBody = "client_secret_post";

        /// <summary>
        /// The client uses the JWT Assertion profile with its own private key.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#ClientAuthentication"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7523"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"/>
        public const string PrivateKeyJwt = "private_key_jwt";

        /// <summary>
        /// The client uses the JWT Assertion profile with a symmetric secret issued by the server.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#ClientAuthentication"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7523"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7521"/>
        public const string SecretKeyJwt = "client_secret_jwt";

        /// <summary>
        /// Indicates that client authentication to the authorization server will occur with mutual TLS utilizing the
        /// PKI method of associating a self-signed certificate to a client.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-federation-1_0.html"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8705"/>
        public const string SelfSignedTlsClientAuth = "self_signed_tls_client_auth";

        /// <summary>
        /// Indicates that client authentication to the authorization server will occur with mutual TLS utilizing the
        /// PKI method of associating a certificate to a client.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-federation-1_0.html"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8705"/>
        public const string TlsClientAuth = "tls_client_auth";
    }
}
