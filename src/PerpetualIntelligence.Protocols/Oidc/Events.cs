/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
