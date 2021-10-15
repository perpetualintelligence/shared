/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OpenID Connect authentication protocol response modes.
    /// </summary>
    /// <seealso href="https://openid.net/specs/oauth-v2-multiple-response-types-1_0.html"/>
    /// <seealso href="https://openid.net/specs/oauth-v2-form-post-response-mode-1_0.html">
    /// OAuth 2.0 Multiple Response Type Encoding Practices
    /// </seealso>
    public static class ResponseModes
    {
        /// <summary>
        /// In this mode, Authorization Response parameters are encoded as HTML form values that are auto-submitted in
        /// the User Agent, and thus are transmitted via the HTTP POST method to the Client, with the result parameters
        /// being encoded in the body using the <c>application/x-www-form-urlencoded</c> format. The action attribute of
        /// the form MUST be the Client's Redirection URI. The method of the form attribute MUST be POST. Because the
        /// Authorization Response is intended to be used only once, the Authorization Server MUST instruct the User
        /// Agent (and any intermediaries) not to store or reuse the content of the response. Any technique supported by
        /// the User Agent MAY be used to cause the submission of the form, and any form content necessary to support
        /// this MAY be included, such as submit controls and client-side scripting commands.However, the Client MUST be
        /// able to process the message without regard for the mechanism by which the form submission was initiated.
        /// </summary>
        public const string FormPost = "form_post";

        /// <summary>
        /// In this mode, Authorization Response parameters are encoded in the fragment added to the <c>redirect_uri</c>
        /// when redirecting back to the Client.
        /// </summary>
        public const string Fragment = "fragment";

        /// <summary>
        /// In this mode, Authorization Response parameters are encoded in the query string added to the
        /// <c>redirect_uri</c> when redirecting back to the Client.
        /// </summary>
        public const string Query = "query";
    }
}
