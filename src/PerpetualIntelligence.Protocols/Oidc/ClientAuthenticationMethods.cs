/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The client authentication methods in the OAuth or OpenID Connect protocol.
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7591">OAuth 2.0 Dynamic Client Registration Protocol</seealso>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8705">
    /// OAuth 2.0 Mutual-TLS Client Authentication and Certificate-Bound Access Tokens
    /// </seealso>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8693">OAuth 2.0 Token Exchange</seealso>
    public static class ClientAuthenticationMethods
    {
        /// <summary>
        /// The client uses HTTP Basic as defined in OAuth 2.0.
        /// </summary>
        public const string Basic = "client_secret_basic";

        /// <summary>
        /// The client is a public client as defined in OAuth 2.0, and does not have a client secret.
        /// </summary>
        public const string None = "none";

        /// <summary>
        /// The client uses the HTTP POST parameters as defined in OAuth 2.0, Section 2.3.1.
        /// </summary>
        public const string PostBody = "client_secret_post";

        /// <summary>
        /// The client uses the JWT Assertion profile with its own private key.
        /// </summary>
        public const string PrivateKeyJwt = "private_key_jwt";

        /// <summary>
        /// The client uses the JWT Assertion profile with a symmetric secret issued by the server.
        /// </summary>
        public const string SecretKeyJwt = "client_secret_jwt";

        /// <summary>
        /// Indicates that client authentication to the authorization server will occur with mutual TLS utilizing the
        /// PKI method of associating a self-signed certificate to a client.
        /// </summary>
        public const string SelfSignedTlsClientAuth = "self_signed_tls_client_auth";

        /// <summary>
        /// Indicates that client authentication to the authorization server will occur with mutual TLS utilizing the
        /// PKI method of associating a certificate to a client.
        /// </summary>
        public const string TlsClientAuth = "tls_client_auth";
    }
}
