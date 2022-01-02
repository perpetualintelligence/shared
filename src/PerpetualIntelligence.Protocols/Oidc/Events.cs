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
    /// Defines the events in OpenID Connect authentication protocol.
    /// </summary>
    public static class Events
    {
        /// <summary>
        /// The back channel logout event,
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-backchannel-1_0.html"/>
        public const string BackChannelLogout = "http://schemas.openid.net/event/backchannel-logout";
    }
}
