/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The code challenge methods in the OAuth or OpenID Connect authentication protocol.
    /// </summary>
    /// <see href="https://datatracker.ietf.org/doc/html/rfc7636"></see>
    public static class CodeChallengeMethods
    {
        /// <summary>
        /// <c>code_challenge = code_verifier</c>
        /// </summary>
        public const string Plain = "plain";

        /// <summary>
        /// <c>code_challenge = BASE64URL-ENCODE(SHA256(ASCII(code_verifier)))</c>
        /// </summary>
        public const string Sha256 = "S256";
    }
}
