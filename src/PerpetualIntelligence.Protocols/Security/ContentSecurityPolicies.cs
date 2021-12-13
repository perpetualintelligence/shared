/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        /// The content security policy level 1. See <see href="https://www.w3.org/TR/CSP1/"/> for more information.
        /// </summary>
        public const string Level1 = "urn:pi:protocol:security:csp:l1";

        /// <summary>
        /// The content security policy level 2. See <see href="https://www.w3.org/TR/CSP2/"/> for more information.
        /// </summary>
        public const string Level2 = "urn:pi:protocol:security:csp:l2";

        /// <summary>
        /// The content security policy level 3. See <see href="https://www.w3.org/TR/CSP3/"/> for more information.
        /// </summary>
        [Obsolete("The content security policy level 3 is not yet supported. The support may come in future release. Please use level 1 or level 2.")]
        public const string Level3 = "urn:pi:protocol:security:csp:l3";
    }
}
