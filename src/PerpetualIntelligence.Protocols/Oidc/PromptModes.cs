/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OpenID Connect authentication protocol prompt modes.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html">Authentication Request</seealso>
    public static class PromptModes
    {
        /// <summary>
        /// The Authorization Server SHOULD prompt the End-User for consent before returning information to the Client.
        /// If it cannot obtain consent, it MUST return an error, typically <c>consent_required</c>.
        /// </summary>
        public const string Consent = "consent";

        /// <summary>
        /// The Authorization Server SHOULD prompt the End-User for re-authentication. If it cannot re-authenticate the
        /// End-User, it MUST return an error, typically <c>login_required</c>.
        /// </summary>
        public const string Login = "login";

        /// <summary>
        /// The Authorization Server MUST NOT display any authentication or consent user interface pages. An error is
        /// returned if an End-User is not already authenticated or the Client does not have pre-configured consent for
        /// the requested Claims or does not fulfill other conditions for processing the request. The error code will
        /// typically be <c>login_required</c>, <c>interaction_required</c>, or another code defined in Section 3.1.2.6.
        /// This can be used as a method to check for existing authentication and/or consent.
        /// </summary>
        public const string None = "none";

        /// <summary>
        /// The Authorization Server SHOULD prompt the End-User to select a user account. This enables an End-User who
        /// has multiple accounts at the Authorization Server to select amongst the multiple accounts that they might
        /// have current sessions for. If it cannot obtain an account selection choice made by the End-User, it MUST
        /// return an error, typically <c>account_selection_required</c>.
        /// </summary>
        public const string SelectAccount = "select_account";
    }
}
