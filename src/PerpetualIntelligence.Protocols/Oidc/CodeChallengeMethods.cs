/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
