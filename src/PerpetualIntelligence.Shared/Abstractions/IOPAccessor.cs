/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to access the <c>OP</c> or OpenID Provider.
    /// </summary>
    /// <remarks>
    /// The <see cref="IOPAccessor"/> is typically used to configure <c>RP</c> or Relying Party to send the
    /// authorization, profile and registration requests to the OP.
    /// </remarks>
    public interface IOPAccessor
    {
        /// <summary>
        /// The OP authority.
        /// </summary>
        /// <value>The <see cref="Uri.Authority"/> of the OP.</value>
        string Authority { get; }

        /// <summary>
        /// The authorization endpoint relative to <see cref="Authority"/>.
        /// </summary>
        /// <value>The authorization endpoint of the OP.</value>
        string AuthorizeEndpoint { get; }

        /// <summary>
        /// The <c>client_id</c>.
        /// </summary>
        /// <value>The <c>client_id</c>.</value>
        string ClientId { get; }

        /// <summary>
        /// The absolute <c>client_uri</c>.
        /// </summary>
        /// <value>The absolute <c>client_id</c>.</value>
        string ClientUri { get; }

        /// <summary>
        /// The default <c>scope</c>.
        /// </summary>
        /// <value>The default <c>scope</c>.</value>
        string[] DefaultScopes { get; }

        /// <summary>
        /// The absolute <c>post_logout_redirect_uri</c>.
        /// </summary>
        /// <value>The absolute <c>post_logout_redirect_uri</c>.</value>
        string PostLogoutRedirectUri { get; }

        /// <summary>
        /// The profile endpoint relative to <see cref="Authority"/>.
        /// </summary>
        /// <value>The profile endpoint of the OP.</value>
        string ProfileEndpoint { get; }

        /// <summary>
        /// The <c>redirect_uri</c>.
        /// </summary>
        /// <value>The <c>redirect_uri</c>.</value>
        string RedirectUri { get; }

        /// <summary>
        /// The registration endpoint relative to <see cref="Authority"/>.
        /// </summary>
        /// <value>The registration endpoint of the OP.</value>
        string RegisterEndpoint { get; }

        /// <summary>
        /// The <c>response_type</c>.
        /// </summary>
        /// <value>The <c>response_type</c>.</value>
        string ResponseType { get; }

        /// <summary>
        /// The token endpoint relative to <see cref="Authority"/>.
        /// </summary>
        /// <value>The token endpoint of the OP.</value>
        string TokenEndpoint { get; }
    }
}
