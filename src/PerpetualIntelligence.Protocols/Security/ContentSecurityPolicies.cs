/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System;

namespace PerpetualIntelligence.Protocols.Security
{
    /// <summary>
    /// Defines the content security policy levels.
    /// </summary>
    public static class ContentSecurityPolicies
    {
        /// <summary>
        /// The content security policy level 1.
        /// </summary>
        /// <seealso href="https://www.w3.org/TR/CSP1/"/>
        public const string Level1 = "urn:oneimlx:security:csp:l1";

        /// <summary>
        /// The content security policy level 2.
        /// </summary>
        /// <seealso href="https://www.w3.org/TR/CSP2/"/>
        public const string Level2 = "urn:oneimlx:security:csp:l2";

        /// <summary>
        /// The content security policy level 3.
        /// </summary>
        /// <seealso href="https://www.w3.org/TR/CSP2/"/>
        [Obsolete("The content security policy level 3 is not yet supported. The support may come in future release. Please use level 1 or level 2.")]
        public const string Level3 = "urn:oneimlx:security:csp:l3";
    }
}
